package com.example.restaurantrating;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.os.StrictMode;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.RatingBar;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import java.util.List;

public class MainActivity extends AppCompatActivity {
    EditText editName, editPhone, editAddress, editDescription;
    Button btnInsert;
    ListView listView;
    RatingBar ratingBar;

    public class CustomArrayAdapter extends ArrayAdapter<DatabaseHelper.Restaurants> {
        private Context context;
        private int resource;


        public CustomArrayAdapter(@NonNull Context context, int resource, @NonNull List<DatabaseHelper.Restaurants> objects) {
            super(context, resource, objects);
            this.context = context;
            this.resource = resource;
        }
        @Override
        public View getView(int position, View convertView, ViewGroup parent){
            DatabaseHelper.Restaurants restaurants = getItem(position);

            if(convertView == null){
                convertView = LayoutInflater.from(context).inflate(resource,
                        parent, false);
            }
            TextView viewID =convertView.findViewById(R.id.listViewID);
            viewID.setText(restaurants.getID());
            TextView viewName =convertView.findViewById(R.id.listViewName);
            viewName.setText(restaurants.getName());
            TextView viewAddress =convertView.findViewById(R.id.listViewAddress);
            viewAddress.setText(restaurants.getAddress());
            TextView viewPhone =convertView.findViewById(R.id.listViewPhone);
            viewPhone.setText(restaurants.getPhone());
            TextView viewDescription =convertView.findViewById(R.id.listViewDescription);
            viewDescription.setText(restaurants.getDescription());
            RatingBar viewRatingBar =convertView.findViewById(R.id.listViewRatingBar);
            viewRatingBar.setRating(restaurants.getRatingBar());
            return  convertView;

        }

    }

    protected void FillListView(){
        try (DatabaseHelper db = new DatabaseHelper(getApplicationContext())){
            List<DatabaseHelper.Restaurants> restaurants = db.select();
            CustomArrayAdapter arrayAdapter = new CustomArrayAdapter(
                    this,
                    R.layout.activity_list_view,
                    restaurants
            );

            listView.clearChoices();
            listView.setAdapter(arrayAdapter);
        }
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data){
        super.onActivityResult(requestCode, resultCode, data);
        FillListView();
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        editName = findViewById(R.id.editName);
        editPhone = findViewById(R.id.editPhone);
        editAddress = findViewById(R.id.editAddress);
        editDescription = findViewById(R.id.editDescription);
        btnInsert = findViewById(R.id.btnInsert);
        listView = findViewById(R.id.listView);
        ratingBar = findViewById(R.id.ratingBar);

//        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
//        StrictMode.setThreadPolicy(policy);

        FillListView();

        listView.setOnItemClickListener(
                new AdapterView.OnItemClickListener() {
                    @Override
                    public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                        Bundle bundle = new Bundle();
                        bundle.putString("ID", ((TextView)(view.findViewById(R.id.listViewID))).getText().toString() );
                        bundle.putString("Name", ((TextView)(view.findViewById(R.id.listViewName))).getText().toString() );
                        bundle.putString("Address", ((TextView)(view.findViewById(R.id.listViewAddress))).getText().toString() );
                        bundle.putString("Phone", ((TextView)(view.findViewById(R.id.listViewPhone))).getText().toString() );
                        bundle.putString("Description", ((TextView)(view.findViewById(R.id.listViewDescription))).getText().toString() );
                        bundle.putFloat("RatingBar", ((RatingBar)(view.findViewById(R.id.listViewRatingBar))).getRating() );

                        Intent intent = new Intent(MainActivity.this, UpdateDelete.class);
                        intent.putExtras(bundle);

                        startActivityForResult(intent, 202, bundle);


                    }
                }
        );

        btnInsert.setOnClickListener(view -> {
            try (DatabaseHelper db = new DatabaseHelper(getApplicationContext())){
                db.insert(
                        editName.getText().toString(),
                        editPhone.getText().toString(),
                        editAddress.getText().toString(),
                        editDescription.getText().toString(),
                        ratingBar.getRating()
                );

                Toast.makeText(getApplicationContext(), "Inserted Successfully!",
                        Toast.LENGTH_LONG).show();
            } catch (Exception e) {
                Toast.makeText(getApplicationContext(),
                        e.getLocalizedMessage(), Toast.LENGTH_LONG).show();
            }


            FillListView();
        });


    }
}