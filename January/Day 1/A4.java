import java.io.*;
import java.util.*;

/**
 * Created with IntelliJ IDEA.
 * User: Aditya Kolla
 * Date: 2/1/19
 */
public class A4 {
    static FastReader in;

    public static void main(String[] args) {
        in = new FastReader();
        int n = ni();
        ArrayList<String> list = new ArrayList<>();
        while (n-->0){
            String s = n();
            if(!list.contains(s)){
                pn("NO");
            }else pn("YES");
            list.add(s);
        }
    }

    static void p(Object o) {
        System.out.print(o);
    }

    static void pn(Object o) {
        System.out.println(o);
    }

    static String n() {
        return in.next();
    }

    static String nln() {
        return in.nextLine();
    }

    static int ni() {
        return in.nextInt();
    }

    static int[] ia(int N) {
        int[] a = new int[N];
        for (int i = 0; i < N; i++) a[i] = ni();
        return a;
    }

    static long[] la(int N) {
        long[] a = new long[N];
        for (int i = 0; i < N; i++) a[i] = nl();
        return a;
    }

    static long nl() {
        return Long.parseLong(in.next());
    }

    static double nd() {
        return Double.parseDouble(in.next());
    }

    static class FastReader {
        BufferedReader br;
        StringTokenizer st;

        public FastReader() {
            br = new BufferedReader(new
                    InputStreamReader(System.in));
        }

        String next() {
            while (st == null || !st.hasMoreElements()) {
                try {
                    st = new StringTokenizer(br.readLine());
                } catch (IOException e) {
                    e.printStackTrace();
                }
            }
            return st.nextToken();
        }

        int nextInt() {
            return Integer.parseInt(next());
        }

        long nextLong() {
            return Long.parseLong(next());
        }

        double nextDouble() {
            return Double.parseDouble(next());
        }

        String nextLine() {
            String str = "";
            try {
                str = br.readLine();
            } catch (IOException e) {
                e.printStackTrace();
            }
            return str;
        }
    }
}
