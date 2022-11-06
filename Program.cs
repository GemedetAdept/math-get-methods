double[] angles = new double[] {

	22.5, 45.0, 67.5, 
	112.5, 135.0, 157.5, 
	202.5, 225.0, 247.5,
	292.5, 315.0, 337.5,

};


(double x, double y) coords = (0.0, 0.0);
double radians = 0.0;
double radius = 3.0;

Console.WriteLine("Angle, Radians, X, Y");
Console.WriteLine($"For radius = {radius}");
foreach(double angle in angles) {

	radians = MathGet.DegreesToRadians(angle);
	coords = MathGet.DegreesToCoords(angle, radius);

	Console.WriteLine($"{angle:000.0}, {radians:0.0000}, {coords}");

}