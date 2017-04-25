package com.example.isurianuradha.mynotification;

import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.support.v7.app.NotificationCompat;

/**
 * Created by isurianuradha on 1/19/17.
 */
public class Notification_reciever extends BroadcastReceiver{

    @Override
    public void onReceive(Context context, Intent intent) {

        NotificationManager notificationManager = (NotificationManager) context.getSystemService(Context.NOTIFICATION_SERVICE);

        Intent repeting_intent = new Intent(context, Repeating_activity.class);
        repeting_intent.setFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);

        PendingIntent pendingIntent = PendingIntent.getActivity(context,100,repeting_intent,PendingIntent.FLAG_UPDATE_CURRENT);

      NotificationCompat.Builder builder = (NotificationCompat.Builder) new NotificationCompat.Builder(context)
                .setContentIntent(pendingIntent)
                .setSmallIcon(android.R.drawable.arrow_up_float)
                .setContentTitle("DONT FORGET TO FEED YOUR BABY")
                .setContentText("This is time to feed your baby. Don't keep your baby hungry ..")
                .setAutoCancel(true);

      notificationManager.notify(100,builder.build());
    }
}
