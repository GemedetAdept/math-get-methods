double[] pointA = new double[2];
double[] pointB = new double[2];

double[] inputPoint(double[] point, string ordinal) {

	Console.WriteLine($"Input coordinates of {ordinal} point; '(x, y)'");
	Console.Write("> ");
	string userInput = Console.ReadLine();
	string[] splitInput = userInput.Replace("(", "").Replace(")", "").Split(", ");

	for (int i=0; i < splitInput.Length; i++) {

		point[i] = Double.Parse(splitInput[i]);
	}

	Console.WriteLine("");

	return point;
}

inputPoint(pointA, "first");
inputPoint(pointB, "second");

Console.WriteLine(MathGet.LineLength2D(pointA, pointB));
// Console.WriteLine($"({pointA[0]}, {pointA[1]}), ({pointB[0]}, {pointB[1]})");