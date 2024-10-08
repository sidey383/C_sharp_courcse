namespace Nsu.HackathonProblem {

    public class MathUtils {

        public static double harmonicMean(IEnumerable<int> values) {
            double sum = 0;
            foreach (int val in values) {
                sum += 1/(double)val;
            }
            return values.Count()/sum;
        }

        public static int findPose(int[] order, int graded) {
                int number = 0;
                while (number < order.Length) {
                    if (order[number] == graded)
                        return number;
                }
                throw new ArgumentException(string.Format("Cant't found '{0}' in '{1}'", graded, order));
            }

    }
}