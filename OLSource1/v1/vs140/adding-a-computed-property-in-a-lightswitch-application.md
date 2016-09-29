---
title: "Adding a Computed Property in a LightSwitch Application"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio LightSwitch, adding a computed property"
ms.assetid: fcd5f344-5921-4f67-99e7-64e5ae84b5df
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Adding a Computed Property in a LightSwitch Application
This lesson shows how to calculate data by using a computed property in a LightSwitch application.  
  
## Adding a Computed Property  
 Most data for business applications is stored in a database or other data source, but you can also use a computed property to provide data that's based on a calculation. The data can appear on a screen without being stored in a database.  
  
 For example, an order total is a computed property for which you write code to add together line-item amounts, tax, and shipping.  
  
#### To add a computed property  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Orders.lsml** node, and then choose **Open**.  
  
2.  In the **Data Designer**, on the **Perspective** bar, choose **Server**, and then choose the **<Add Property\>** link and enter `OrderTotal`.  
  
3.  In the **Type** column, choose **Money**.  
  
     In the **Properties** window, the **IsComputed** property is checked and an **Edit Method** link is added.  
  
4.  In the **Properties** window, choose the **Edit Method** link.  
  
     The **Code Editor** opens and displays the `OrderTotal_Compute` method.  
  
5.  In the `OrderTotal_Compute` method, add the following code.  
  
    ```vb  
    For Each Order_Detail In Order_Details  
        result = result + (Order_Detail.UnitPrice * Order_Detail.Quantity)  
    Next  
    result = result + Freight  
    ```  
  
    ```c#  
    foreach (Order_Detail od in Order_Details) {  
  
        result = result += (od.UnitPrice * od.Quantity);  
    }  
    result = result + Freight.Value;  
    ```  
  
     When an order appears on a screen, this code will run and calculate the order total. See the next section for an explanation of the code.  
  
## Closer Look  
 This lesson showed how to add a computed property to an entity to calculate a value. You may have noticed that when you added the **OrderTotal** field to the **Orders** entity, the field was marked as required. In the **Properties** window, the **IsComputed** option was also automatically enabled. Computed fields for entities from an attached data source are always both required and computed.  
  
 The code example uses a `For… Each` construct to loop through the `Order_Detail` entity. For each line item, the code multiplies the item’s price (`UnitPrice` field) by the number of items ordered (`Quantity` field), and then stores the accumulated total in the `result` variable. The final line of code adds the value of the shipping charge (`Freight` field) to the accumulated total. You could improve this code by verifying whether the `Freight` field has a value. As currently written, the `Freight` field could cause an exception if a user leaves it empty.  
  
 Computed properties don't always involve mathematical calculations. You can also use a computed property to concatenate two strings. For example, you could create a `FullName` field that displays a `FirstName` field and a `LastName` field together. In this case, the code for the `FullName_Compute` method would look like this:  
  
```vb  
result = FirstName & " " & LastName  
```  
  
```c#  
result = FirstName + " " + LastName  
```  
  
 For a `FirstName` of "Howard" and a `LastName` of "Snyder", the `FullName` would appear on a screen as "Howard Snyder".  
  
 You can also create a computed property that uses the values of other computed properties. For example, you could add a `Tax` property to the `Orders` entity, and then write code to calculate tax based on a percentage of the computed `OrderTotal` property.  
  
 Computed properties also have some limitations. You can’t use them in a query, and end users can’t sort or search a computed column.  
  
## Next Steps  
 In the next lesson, you’ll learn how to create relationships between data entities.  
  
 Next lesson: [Defining Relationships](../vs140/defining-relationships-in-a-lightswitch-application.md)  
  
## See Also  
 [Working with Data in Kitty Hawk (Guided Tour)](../vs140/working-with-data-in-lightswitch.md)   
 [How to: Define a Calculated Field](../vs140/how-to--add-a-computed-field-in-a-lightswitch-database.md)