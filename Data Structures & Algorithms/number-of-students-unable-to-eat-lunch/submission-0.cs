public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        // want[0] = students preferring circular, want[1] = preferring square
        int[] want = new int[2];
        foreach (int s in students) {
            want[s]++;
        }

        // Process the stack top-to-bottom
        foreach (int sandwich in sandwiches) {
            if (want[sandwich] == 0) {
                // No one left wants this sandwich → deadlock
                return want[0] + want[1];
            }
            want[sandwich]--;
        }

        // Every sandwich got eaten
        return 0;
    }
}