using System;

namespace LinkedList {
    public class Operatiion {
        public static Node head;

        public static void add(int data) {
            Node toAdd = new Node(data);

            if(head == null) {
                head = toAdd;
                return;
            }

            Node temp = head;

            while(temp.next != null) {
                temp = temp.next;
            }

            temp.next = toAdd;
        }

        public static void addToHead(int data) {
            Node toAdd = new Node(data);

            if(head == null) {
                head = toAdd;
                return;
            }

            toAdd.next = head;

        }

        public static void show() {
            Node temp = head;

            while(temp.next != null) {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
            Console.WriteLine(temp.data);
        }
    }
}