double[] pointA = new double[2];
double[] pointB = new double[2];

double[] inputPoint(double[] point, string pointName) {

	Console.WriteLine("Input coordinates of first point; '(x, y)'");
	Console.Write("> ");
	string userInput = Console.ReadLine();
	string[] splitInput = inputX.Replace("(", "").Replace(")", "").Split(", ");

	point = splitInputX.Select(a => Convert.ToDouble(a)).ToArray();
}

Console.WriteLine(pointA[0] + ", " + pointA[1]);