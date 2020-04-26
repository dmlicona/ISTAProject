# ISTA_Project_Step6
## *Denis Licona*
###### *26 Feb 2020* 

**Use Case Description:** After the user has selected and designed a cake pop to purchase and then order the items, the user will provide payment. The system will respond with confirmation of the order, a confirmation number, and a confirmation of the requested delivery date. 

**Use Case Name:** Place Cake Pop Order

**Actors:**

- Shopper (provides contact information and generates an order)
- Fulfillment Website (processes orders to be delivered to the shopper)
- Billing System (bills shopper for orders that have been placed)

**Triggers:**

The user indicates that he/she wants to purchase a cake pop by placing an order.

**Preconditions:**

User has selected the cake pop design to be purchased.

**Post-conditions:**

The order will be placed in the system.
The user will have an order ID for the order.
The user's requested delivery date for the order is confirmed.

**Normal Flow:**

1. The user designs a cake pop on the company's website.
1. The system tallies the total cost for the cake pop as the user select design options.
1. The user will indicate that he/she wants to order the designed cake pops by placing an order and the desired amount. 
1. The system will present the amount that the order will cost, including applicable taxes. 
1. The user is asked to either create an account or place order as a guest. 
1. The user creates an account and inputs contact information. 
1. The user enters billing information for the order. 
1. The user will confirm that the imputed contact and billing information should be used for the order.
1. The user will confirm that the order information is accurate.
1. The system will provide the user with an order ID for the order.
1. The system will submit the order to the fulfillment system for evaluation.
1. The system will present the confirmed delivery date to the user.
1. The user will indicate that the order should be placed.
1. The system will request that the billing system should charge the user for the order.
1. The billing system will confirm that the charge has been placed for the order.
1. The system will submit the order to the company for processing.
1. The system will indicate to the user that the user has been charged for the order.
1. The system will indicate to the user that the order has been placed.
1. The user will exit the system.

**Alternate Flows:**

- 5A1: The user chooses to place the order as a guest. This alternate flow applies if the user does not have an account. The system jumps to step 7.

- 5A2: The user has an existing account and enters username and password. This alternate flow applies if the user has an active account. The system jumps to step 8. If the information is not correct, the user can select to edit or update the information. The systems continues to step 9. If the user desires to use shipping and billing information that differs from the information stored in her account. 
