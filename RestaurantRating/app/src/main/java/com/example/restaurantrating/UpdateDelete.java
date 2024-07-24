package com.example.restaurantrating;

import android.content.Intent;
import android.location.Address;
import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RatingBar;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class UpdateDelete extends AppCompatActivity {
    EditText editName, editPhone, editAddress, editDescription;
    Button btnUpdate, btnDelete;
    RatingBar ratingBar;

    String ID;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_update_delete);

        editName = findViewById(R.id.editName);
        editPhone = findViewById(R.id.editPhone);
        editAddress = findViewById(R.id.editAddress);
        editDescription = findViewById(R.id.editDescription);
        btnUpdate = findViewById(R.id.btnUpdate);
        btnDelete = findViewById(R.id.btnDelete);
        ratingBar = findViewById(R.id.editRatingBar);


        Bundle b = getIntent().getExtras();
        ID = b.getString("ID");
        editName.setText(b.getString("Name"));
        editAddress.setText(b.getString("Address"));
        editPhone.setText(b.getString("Phone"));
        editDescription.setText(b.getString("Description"));
        ratingBar.setRating(b.getFloat("RatingBar"));

        findViewById(R.id.btnShowMap).setOnClickListener(
                view -> {
                    Bundle bundle = new Bundle();
                    bundle.putString("ID", ID);
                    bundle.putString("Phone", editPhone.getText().toString());
                    bundle.putString("Address", editAddress.getText().toString());
                    bundle.putString("Description", editDescription.getText().toString());
                    bundle.putFloat("RatingBar", ratingBar.getRating());

                    Intent intent = new Intent(
                        UpdateDelete.this,
                            MapsActivity.class
                    );
                    intent.putExtras(bundle);
                    startActivity(intent, bundle);
                }
        );

        btnUpdate.setOnClickListener(view -> {
            try (DatabaseHelper db = new DatabaseHelper(getApplicationContext())){
                db.update(
                        editName.getText().toString(),
                        editPhone.getText().toString(),
                        editAddress.getText().toString(),
                        editDescription.getText().toString(),
                        ratingBar.getRating(),
                        ID
                );
                Toast.makeText(getApplicationContext(), "Updated Successfully!", Toast.LENGTH_LONG)
                        .show();
            } catch (Exception e) {
                Toast.makeText(getApplicationContext(), e.getMessage(), Toast.LENGTH_LONG)
                        .show();
            }

            BackToMain();
        });

        btnDelete.setOnClickListener(view -> {
            try (DatabaseHelper db = new DatabaseHelper(getApplicationContext())){
                db.delete(
                        ID
                );
                Toast.makeText(getApplicationContext(), "Deleted Successfully!", Toast.LENGTH_LONG)
                        .show();
            } catch (Exception e) {
                Toast.makeText(getApplicationContext(), e.getMessage(), Toast.LENGTH_LONG)
                        .show();
            }

            BackToMain();
        });
    }

    private void BackToMain() {
        finishActivity(202);
        Intent intent = new Intent(UpdateDelete.this, MainActivity.class);
        startActivity(intent);
    }
}