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

	public static (double, double) DegreesToCoords(double degrees, double radius = 1.0) {

		(double coordX, double coordY) coordinate = (0.0, 0.0);

		double radians = DegreesToRadians(degrees);

		coordinate.coordX = Math.Cos(radians) * radius;
		coordinate.coordY = Math.Sin(radians) * radius;

		return coordinate;
	}

	public static double LineLength2D(double[] a, double[] b) {

		double length = 0.0;
		
		if (a.Length == b.Length) {

			var deltaVals = new double[a.Length+1];

			for (int i=0; i < a.Length; i++)
				deltaVals[i] = Math.Pow((b[i] - a[i]), 2);

			length = Math.Sqrt(deltaVals[0] + deltaVals[1]);
		}

		return length;
	}
}