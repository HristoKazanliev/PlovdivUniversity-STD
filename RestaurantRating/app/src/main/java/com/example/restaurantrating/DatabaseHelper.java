package com.example.restaurantrating;

import android.annotation.SuppressLint;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

import java.util.ArrayList;
import java.util.List;

public class DatabaseHelper extends SQLiteOpenHelper {
    public static final String DBNAME = "restaurants.db";
    public static final int DBVERSION = 1;
    private SQLiteDatabase _myDB;
    public class Restaurants {
        protected String Name, ID, Address, Description, Phone;
        protected float RatingBar;
        public Restaurants(){
            Name=""; ID=""; Address=""; Description=""; Phone = "";
        }
        public Restaurants(String ID, String Name, String Address, String Description, String Phone, float RatingBar){
            this.ID = ID; this.Name=Name; this.Address=Address;
            this.Description = Description; this.Phone = Phone;
            this.RatingBar = RatingBar;

        }
        public String getName(){
            return Name;
        }
        public String getID(){
            return ID;
        }
        public String getAddress(){
            return Address;
        }
        public String getDescription(){
            return Description;
        }
        public String getPhone(){
            return Phone;
        }
        public float getRatingBar(){
            return RatingBar;
        }
    }
    public static String DBCREATE = "" +
            "CREATE TABLE restaurants(" +
            "ID integer PRIMARY KEY AUTOINCREMENT, " +
            "Name text not null, " +
            "Phone text not null, " +
            "Address text not null, " +
            "Description text not null, " +
            "RatingBar text, " +
            "UNIQUE(Name, Phone) " +
            ")";

    public DatabaseHelper(@Nullable Context context) {
        super(context, DBNAME, null, DBVERSION);
        _myDB = this.getWritableDatabase();
    }

    @Override
    public void onCreate(SQLiteDatabase sqLiteDatabase) {
        sqLiteDatabase.execSQL(DBCREATE);
    }

    @Override
    public void onUpgrade(SQLiteDatabase sqLiteDatabase, int oldVersion, int newVersion) {
        if (newVersion > oldVersion) {
            sqLiteDatabase.execSQL("DROP TABLE restaurants; ");
            sqLiteDatabase.execSQL(DBCREATE);
        }
    }

    public void insert(String Name, String Phone, String Address, String Description, float RatingBar) {
        _myDB.execSQL(
                "INSERT INTO restaurants(Name, Phone, Address, Description, RatingBar) " +
                        "VALUES(?, ?, ?, ?, ?)",
                        new Object[]{
                                Name, Phone, Address, Description, RatingBar
                        }
        );
    }

    public void update(String Name, String Phone, String Address, String Description, float RatingBar, String ID) {
        _myDB.execSQL(
                "UPDATE restaurants SET Name = ?, Phone = ?, Address = ?, Description = ?, RatingBar = ? " +
                        " WHERE ID = ? ",
                new Object[]{
                        Name, Phone, Address, Description, RatingBar, ID
                }
        );
    }

    public void delete(String ID) {
        _myDB.execSQL(
                "DELETE FROM restaurants " +
                        " WHERE ID = ?",
                new Object[]{
                        ID
                }
        );
    }

    public List<Restaurants> select(){
        try (Cursor cursor = _myDB.rawQuery("SELECT * FROM restaurants " +
        "ORDER BY Name", null)){
            List<Restaurants> restaurantsList = new ArrayList<>();
            while (cursor.moveToNext()){
                @SuppressLint("Range") Restaurants restaurants = new Restaurants(
                    cursor.getString(cursor.getColumnIndex("ID")),
                        cursor.getString(cursor.getColumnIndex("Name")),
                        cursor.getString(cursor.getColumnIndex("Address")),
                        cursor.getString(cursor.getColumnIndex("Description")),
                        cursor.getString(cursor.getColumnIndex("Phone")),
                        cursor.getFloat(cursor.getColumnIndex("RatingBar"))
                );
                restaurantsList.add(restaurants);
            }
            return restaurantsList;
        }
    }
}
