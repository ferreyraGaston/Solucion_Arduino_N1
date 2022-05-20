
//declaro una variable global
int num1=0;
//int num2=0;
//declaro una constante
const int PIN_LED=13;

void setup() {
  // solo para ejecutar los datos iniciales
  Serial.begin(9600);
  pinMode(PIN_LED, OUTPUT);  // configuro la salida

}

void loop() {
  // es el que se ejecuta constantemente
  
  Serial.println(num1); //envia datos
  if(Serial.available()>0){
     
    int Mycaracter=Serial.read();
    
    if(Mycaracter=='E'){
      digitalWrite(PIN_LED,HIGH);
 
      }
     if(Mycaracter=='S'){
 
      digitalWrite(PIN_LED,LOW);

      }
    
    }
  
}
