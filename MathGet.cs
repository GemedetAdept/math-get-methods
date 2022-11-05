public class MathGet {

	public static double DegreesToRadians(double degrees) {

		double radians = 0.0;
		radians = degrees * (Math.PI / 180);

		return radians;
	}

	public static double RadiansToDegrees(double radians) {

		double degrees = 0.0;
		degrees = radians * (180 / Math.PI);

		return degrees;
	}

	public static (double, double) DegreesToCoords(double degrees) {

		(double coordX, double coordY) coordinate = (0.0, 0.0);

		double radians = DegreesToRadians(degrees);

		coordinate.coordX = Math.Cos(radians);
		coordinate.coordY = Math.Sin(radians);

		return coordinate;
	}
}