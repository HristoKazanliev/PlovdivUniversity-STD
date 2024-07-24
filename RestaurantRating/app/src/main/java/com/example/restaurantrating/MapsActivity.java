package com.example.restaurantrating;

import androidx.fragment.app.FragmentActivity;

import android.location.Address;
import android.location.Geocoder;
import android.os.Bundle;
import android.widget.Toast;

import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.OnMapReadyCallback;
import com.google.android.gms.maps.SupportMapFragment;
import com.google.android.gms.maps.model.CameraPosition;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.MarkerOptions;
import com.example.restaurantrating.databinding.ActivityMapsBinding;

import java.io.IOException;
import java.util.ArrayList;

public class MapsActivity extends FragmentActivity implements OnMapReadyCallback {

    private GoogleMap mMap;
    private ActivityMapsBinding binding;
    private String address;
    private Bundle bundle;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        binding = ActivityMapsBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        // Obtain the SupportMapFragment and get notified when the map is ready to be used.
        SupportMapFragment mapFragment = (SupportMapFragment) getSupportFragmentManager()
                .findFragmentById(R.id.map);
        mapFragment.getMapAsync(this);

        bundle = getIntent().getExtras();
        address = bundle.getString("Address");
    }

    private LatLng geocodeAddress(String address){
        Geocoder geocoder = new Geocoder(this);
        ArrayList<Address> addresses;
        try {
            addresses = (ArrayList<Address>) geocoder.getFromLocationName(address, 1);
            if (addresses == null || address.isEmpty()){
                return null;
            }
            Address location = addresses.get(0);
            return new LatLng(location.getLatitude(), location.getLongitude());
        } catch (IOException e) {
            runOnUiThread(() -> Toast.makeText(
                    getApplicationContext(),
                    e.getLocalizedMessage(),
                    Toast.LENGTH_LONG
            ).show());
            return null;
        }
    }

    /**
     * Manipulates the map once available.
     * This callback is triggered when the map is ready to be used.
     * This is where we can add markers or lines, add listeners or move the camera. In this case,
     * we just add a marker near Sydney, Australia.
     * If Google Play services is not installed on the device, the user will be prompted to install
     * it inside the SupportMapFragment. This method will only be triggered once the user has
     * installed Google Play services and returned to the app.
     */
    @Override
    public void onMapReady(GoogleMap googleMap) {
        mMap = googleMap;
        LatLng location = geocodeAddress(address);
        if(location != null){
            mMap.addMarker(
                    new MarkerOptions().position(location).title("Marker in "+address)
            );
            CameraPosition cameraPosition = new CameraPosition.Builder()
                    .target(location)
                    .zoom(17)
                    .build();
            mMap.animateCamera(CameraUpdateFactory.newCameraPosition(cameraPosition));

        }else{
            runOnUiThread(()->
                    Toast.makeText(getApplicationContext(), "Address not found",
                            Toast.LENGTH_LONG).show()
            );
        }
    }


}