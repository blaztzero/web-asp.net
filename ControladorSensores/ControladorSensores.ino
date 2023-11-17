
#include <max6675.h>
#include <LiquidCrystal_I2C.h>
float r1=100000;
float r2=10000 ;
String mensajeBienvenida = "";
LiquidCrystal_I2C lcd(0x27,16,4);
int thermoDO = 8;
int thermoCS = 9;
int thermoCLK = 10;
int thermoCS2 = 11;

  MAX6675 thermocouple(thermoCLK, thermoCS, thermoDO);
  MAX6675 thermocouple2(thermoCLK, thermoCS2, thermoDO);

void setup() {
  // put your setup code here, to run once:
   Serial.begin(9600);
  lcd.init();
  lcd.backlight();
  lcd.clear();
 


  delay(300);
  lcd.clear();

}

void loop() {
  // put your main code here, to run repeatedly:
float v =(analogRead(1)*5)/1023.0;
float resultado=(v/(r2/(r1+r2)));

     lcd.setCursor(0,1);
    
  lcd.setCursor(0,0);
  lcd.print(thermocouple.readCelsius());
  Serial.print("Sensor 1: ");
   Serial.println(thermocouple.readCelsius());
  lcd.setCursor(6,0);
  lcd.print(" Grados");
  
  
  lcd.setCursor(0,1);
  lcd.print("----------------------");
  //lcd.scrollDisplayRight();
  lcd.setCursor(0,2);
  lcd.print(thermocouple2.readCelsius());
  Serial.print("Sensor 2: ");
  Serial.println(thermocouple2.readCelsius());

  Serial.print("Sensor 3: ");
  Serial.println((resultado + 0.15));
  lcd.setCursor(6,2);
  lcd.print(" Grados");
  if(thermocouple.readCelsius() > 150.00){
  lcd.setCursor(0,3);
  lcd.print("alta temp");
  }
  else{
    lcd.setCursor(0,3);
      lcd.print("normal      ");
  }
  delay(500);
}
