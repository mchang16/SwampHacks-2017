
float angle = 0;
int xPos = width;
int yPos = height;
int xsize = 100;
int ysize = 100;
int colorLimit = 255;
 
void setup(){
 size(400,400);
colorMode(RGB,colorLimit);
}

void draw(){
  
  fill(random(140,255),random(240,130),random(200,240));
  translate(150,150);
  rotate(angle);
  ellipse(xPos/2,yPos/2,xsize,ysize);


angle+=.5;
}