using LikedLists;
using System.Collections.Generic;
using System.Linq;
using System;

var list1 = new llist() {value = 3, next = null};
list1.next = new llist() {value = 1, next = null};
list1.next.next = new llist() {value = 5, next = null};
list1.next.next.next = new llist() {value = 9, next = null};
list1.next.next.next.next = new llist() {value = 7, next = null};
list1.next.next.next.next.next = new llist() {value = 2, next = null};
list1.next.next.next.next.next.next = new llist() {value = 1, next = null};

var list2 = new llist() {value = 4, next = null};
list2.next = new llist() {value = 6, next = null};
list2.next.next = list1.next.next.next.next;

var result = Intersection.Run(list1, list2);
Console.WriteLine(result.Value);
