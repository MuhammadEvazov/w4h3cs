using Task2;



var circlearea = Circle.CalcCircleArea(20);
var circleperimeter = Circle.CalcCirclePerimeter(20);

var rectanglearea = Rectangle.CalcRectangleArea(10, 20);
var rectangleperimeter = Rectangle.CalcRectanglePerimeter(10, 20);

var trianglearea = Triangle.CalcTriangleArea(10, 20);
var triangleperimeter = Triangle.CalcTrianglePerimeter(10, 20, 30);

Console.WriteLine($"Circle: {circlearea} {circleperimeter}");
Console.WriteLine($"Rectangle: {rectanglearea} {rectangleperimeter}");
Console.WriteLine($"Triangle: {trianglearea} {triangleperimeter}");