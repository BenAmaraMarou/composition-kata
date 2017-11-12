# composition-kata
<*> Welcome to The Restaurant <*>
There is :
-Customer:
-Waiter: serves customer.
-Steward: manages stock.
-Cook: cooks meals.
-Accounting: checks that payment has been done.

The customer has paid and eaten a meal that has been ordered from the waiter and prepared by the cook.

Three implementations:
1- Naive - baseline
2- Composition 
	- the customer pays at the end
	- the customer pays in the begining
3- Async: Calls doesn't care about finishing order.

First start only with customer, waiter and cook, then add steward and accounting.
