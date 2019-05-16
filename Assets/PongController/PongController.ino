#include <HID-Project.h>
#include <HID-Settings.h>

#define X_POT A0
#define Y_POT A1
#define CLR_BTN 7

int lastButtonValue = 0;

void setup() {
  pinMode( X_POT, INPUT );
  pinMode( Y_POT, INPUT );
  pinMode( CLR_BTN, INPUT );
  
//  Serial.begin( 9600 );

Gamepad.begin();
}

void loop() {
//  Serial.print( analogRead( X_POT ) );
//  Serial.print( "," );
//  Serial.print( map(analogRead( X_POT ),0, 1023, -32768, 32767) );
//  Serial.print( "," );
//  Serial.print( digitalRead( CLR_BTN ) );
//  Serial.println();

  int buttonValue = digitalRead( CLR_BTN );

  if (lastButtonValue != buttonValue)
  {
    if (buttonValue == 1){
      Gamepad.press(1);
    }
    else
    {
      Gamepad.release(1);
    }
    
  }

  lastButtonValue = buttonValue;
  
 Gamepad.yAxis(map(analogRead( X_POT ),0, 1023, -32768, 32767));
 Gamepad.ryAxis(map(analogRead( Y_POT ),0, 1023, -32768, 32767));

 Gamepad.write();
 delay(10);
}
