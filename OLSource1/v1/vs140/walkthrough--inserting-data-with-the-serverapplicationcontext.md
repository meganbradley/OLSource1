---
title: "Walkthrough: Inserting Data with the ServerApplicationContext"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 9d140748-7653-4219-aada-0f63db4c4035
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Inserting Data with the ServerApplicationContext
The ServerApplicationContext API lets you access the middle tier (a.k.a. the server tier) of your LightSwitch application from other clients such as web applications that don't understand OData. In this walkthrough you’ll create two .aspx pages to add and view data for a LightSwitch application.  
  
### To create the LightSwitch application  
  
1.  On the menu bar, choose **File**, **New**, **Project**.  
  
2.  In the **New Project** dialog, expand the **Visual Basic** or **Visual C#** node, choose **LightSwitch**, and then choose the **LightSwitch HTML Application** template.  
  
3.  In the **Name** text box, enter <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and then choose the **OK** button.  
  
4.  In **Solution Explorer**, open the shortcut menu for the **Data Sources** node and choose **Add Table**.  
  
5.  In the entity designer, choose the title bar, and then in the **Properties** window choose the **Name** property and enter <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
6.  In the entity designer, add the following fields:  
  
    |Name|Type|Required|  
    |----------|----------|--------------|  
    |Name|String|Yes|  
    |BirthDate|Date|Yes|  
  
7.  On the **Perspective** bar choose **HTMLClient**, and then on the toolbar choose the **Screen** button.  
  
8.  In the **Add New Screen** dialog box choose the **Common Screen Set** template, name it <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and in the **Screen Data** list choose **Birthdays**, and then choose the **OK** button.  
  
### To add a data entry page  
  
1.  In **Solution Explorer**, open the shortcut menu for the **BirthdayTracker.Server** node and choose **Add**, **Web Form**.  
  
2.  In the **Specify Name for Item** dialog box, enter <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and then choose the **OK** button.  
  
3.  In the **AddBirthday.aspx** designer, add the following between the \<div> and \</div> tags:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
4.  On the menu bar, choose **View**, **Code**.  
  
5.  In the Code Editor, replace the existing code with the following code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     The code calls the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method to create a temporary instance of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and then the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and **SaveChanges()** methods of the context are called to add data to the **Birthdays** entity.  
  
### To add a display page  
  
1.  In **Solution Explorer**, open the shortcut menu for the **BirthdayTracker.Server** node and choose **Add**, **Web Form**.  
  
2.  In the **Specify Name for Item** dialog box, enter <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and then choose the **OK** button.  
  
3.  On the menu bar, choose **View**, **Code**.  
  
4.  In the Code Editor, replace the existing code with the following code:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     The code calls the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method to create a temporary instance of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and then loops through the **Birthdays** collection to return all records where the **BirthDate** equals today’s date.  
  
### To test the application  
  
1.  Run the application, and in the address bar of the browser, copy the port number portion of the URL, for example: http://localhost:**12345**/HTMLClient/.  
  
2.  Open a new browser tab and enter <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>*12345*<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, replacing *12345* with the port number.  
  
3.  On the **AddBirthday** web page, choose the text box and enter a name, and then choose the **Add** button.  
  
4.  In the text box, replace the name that you just entered with another name, and then choose the **Add** button.  
  
5.  Switch back to the **BirthdaysSet** application and refresh the page.  
  
     You should see the two names that you just entered.  
  
6.  Choose the **Add** button, and in the **Birthdays** dialog box enter a name and a birthdate other than the current date, and then choose the **Save** button.  
  
7.  Open a new browser tab and enter <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>*12345*<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, replacing *12345* with the port number.  
  
     You should see two entries for the names that you entered on the **AddBirthday** web page, but not the one you entered in the application itself.  
  
## Next Steps  
  
## See Also  
 [LightSwitch ServerApplicationContext](../vs140/lightswitch-serverapplicationcontext.md)   
 [ServerApplicationContext API Reference](../vs140/serverapplicationcontext-api-reference.md)