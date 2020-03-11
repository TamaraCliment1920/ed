package org.institutoserpis.ed.miprimeraapp;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.Toast;



public class MainActivity extends AppCompatActivity {

    private EditText et1,et2;
    private TextView tv1;

    //private RadioButton rb1,rb2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Toast.makeText(this, "Bienvenido", Toast.LENGTH_LONG).show();

        et1 = (EditText) findViewById(R.id.txt_num1);
        et2 = (EditText) findViewById(R.id.txt_num2);
        tv1 = (TextView) findViewById(R.id.txt_resultado);
     }

    //Método SUMAR
    public void Sumar(View view){

       /* String valor1_String=et1.getText().toString();
        String valor2_String=et2.getText().toString();

        int num1=Integer.parseInt(valor1_String);
        int num2=Integer.parseInt(valor2_String);

        int suma=num1+num2;
        String resultado=String.valueOf(suma);

        tv1.setText(resultado);*/

        int num1=Integer.parseInt(et1.getText().toString());
        int num2=Integer.parseInt(et2.getText().toString());

        int suma=num1+num2;

        tv1.setText(String.valueOf(suma));
    }


    //Método RESTAR
    public void Restar(View view){

       /* String valor1_String=et1.getText().toString();
        String valor2_String=et2.getText().toString();

        int num1=Integer.parseInt(valor1_String);
        int num2=Integer.parseInt(valor2_String);

        int resta=num1-um2;
        String resultado=String.valueOf(resta);

        tv1.setText(resultado);*/

        int num1=Integer.parseInt(et1.getText().toString());
        int num2=Integer.parseInt(et2.getText().toString());

        int resta=num1-num2;

        tv1.setText(String.valueOf(resta));
    }
}