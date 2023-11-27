package com.example.myapplication.Model;

public class Item {

    private long id;
    private String title;
    private String date;

    public Item() {
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getDate() {
        return date;
    }

    public void setDate(String date) {
        this.date = date;
    }

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public Item(long id, String title, String date) {
        this.id =  id;
        this.title = title;
        this.date = date;
    }
}
