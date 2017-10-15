# composition-kata
<*> Welcome to The Restaurant <*>
There is :
-Client:
-Waiter: serves client.
-Steward: manages stock.
-Cook: cooks dishes.
-Accounting: checks that payment has been done.

The client has paid and eaten a dish that has been ordered from the waiter and prepared by the cook.

Three implementations:
1- Naive - baseline
2- Composition 
	- the client pay at the end
	- the client pay in the begining
3- Async: Calls doesn't care about finishing order.

First start only with client, waiter and cook, then add steward and accounting.
