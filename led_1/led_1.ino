int pinLed = 9;
char caracter;
String comando;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(pinLed, OUTPUT);

}

void loop() {
  while(Serial.available() > 0){
    caracter = Serial.read();
    comando.concat(caracter);
    delay(15);
    Serial.println("funcionando");
  }
  if(comando.equals("LED_ENCENDIDO")==true){
    digitalWrite(pinLed,HIGH);
    Serial.println("Led Encendido :D");
    delay(1000);
  }
    else if (comando.equals("LED_APAGADO")==true){
    digitalWrite(pinLed,LOW);
    Serial.println("Led APAGADO D:");
    delay(2000);
  }
  // put your main code here, to run repeatedly:

}
