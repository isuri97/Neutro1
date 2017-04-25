package com.example.isurianuradha.mynotification;

import android.app.AlarmManager;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.Context;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.TextView;
import android.widget.Button;
import android.view.View.OnClickListener;

import java.util.Calendar;
import java.util.GregorianCalendar;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        findViewById(R.id.button).setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View view) {


                Long alertTime = new GregorianCalendar().getTimeInMillis() + 5 * 1000;


                AlarmManager alarmManager = (AlarmManager) getSystemService(Context.ALARM_SERVICE);





                /*Calendar calendar = Calendar.getInstance();


                calendar.set(Calendar.HOUR_OF_DAY,10);
                calendar.set(calendar.MINUTE,25);
                 calendar.set(calendar.SECOND,30);*/


                Intent intent = new Intent(getApplicationContext(), Notification_reciever.class);

                PendingIntent pendingIntent = PendingIntent.getBroadcast(getApplicationContext(), 100, intent, PendingIntent.FLAG_UPDATE_CURRENT);

                alarmManager.set(AlarmManager.RTC_WAKEUP, alertTime,
                        PendingIntent.getBroadcast(getApplicationContext(), 1, intent,
                                PendingIntent.FLAG_UPDATE_CURRENT));



                /*AlarmManager alarmManager = (AlarmManager) getSystemService(ALARM_SERVICE);
                alarmManager.setRepeating(AlarmManager.RTC_WAKEUP,calendar.getTimeInMillis(),AlarmManager.INTERVAL_DAY,pendingIntent);*/

            }

        });
    }

    }




