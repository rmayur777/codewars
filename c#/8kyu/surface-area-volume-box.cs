// Write a function that returns the total surface area and volume of a box as an array: [area, volume]

using System;
 
 public class Kata
 {
    public static int[] getSize(int w,int h,int d)
    {
        int area = 2 * (w*h + w *d + h *d);
        int volume = w * h * d;
        return new int[] {area ,  volume};
    }
 }