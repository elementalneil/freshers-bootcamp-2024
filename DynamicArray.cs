using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray {
    public class DynamicArray<T> {
        private T[] array;
        private int count;
        private int capacity;

        public DynamicArray(int initialCapacity) {
            if (initialCapacity <= 0) {
                throw new ArgumentException("Initial capacity must be greater than zero.");
            }

            array = new T[initialCapacity];
            count = 0;
            capacity = initialCapacity;
        }

        public T this[int index] {
            get {
                if (index < 0 || index >= count) {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                return array[index];
            }
            set {
                if (index < 0 || index >= count) {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                this.Add(index, value);
            }
        }

        public int Count {
            get { return count; }
        }

        public int Capacity {
            get { return capacity; }
        }

        public void Add(T value) {
            if (count == capacity) {
                // Double the capacity if the array is full
                ResizeArray();
            }

            array[count] = value;
            count++;
        }

        public void Add(int index, T value) {
            if (index < 0) {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            while (index >= capacity) {
                ResizeArray();
            }

            // Shift elements to make space for the new element
            for (int i = capacity - 1; i > index; i--) {
                array[i] = array[i - 1];
            }

            array[index] = value;
            count++;
        }

        private void ResizeArray() {
            capacity *= 2;
            T[] newArray = new T[capacity];

            for (int i = 0; i < count; i++) {
                newArray[i] = array[i];
            }

            array = newArray;
        }
    }


    public class Program {
        static void Main() {
            DynamicArray<int> numbers = new DynamicArray<int>(2);
            numbers.Add(0, 100);
            numbers.Add(1, 200);
            numbers.Add(2, 300);
            numbers.Add(50, 1000);
            numbers.Add(3, 400);
            int value = numbers[2];
            System.Console.WriteLine($"Total Number Of Items in Array:{numbers.Count} ,Value:{value} at index:2");

            DynamicArray<string> stringItems = new DynamicArray<string>(2);
            stringItems.Add(0, "100");
            stringItems.Add(1, "200");
            stringItems.Add(2, "300");
            stringItems.Add(3, "400");
            string itemValue = stringItems[3];
            System.Console.WriteLine($"Total Number Of Items in Array:{stringItems.Count} , Value:{itemValue} at index:3");
        }
    }
}
