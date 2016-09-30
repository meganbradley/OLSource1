---
title: "Walkthrough: Printing an Invoice from a LightSwitch Application"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 9a8f146d-b566-4c1f-a0ac-7d0104381008
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Printing an Invoice from a LightSwitch Application
You can’t print directly from a LightSwitch application, but you can create a Silverlight user control that implements printing and add it to a LightSwitch screen. This walkthrough shows how to print an invoice by creating a Silverlight user control and using it as a custom control on a form.  
  
##  \<a name="LS">\</a> Create the LightSwitch Application  
 First, you create a simple LightSwitch application with Customer and Order entities and a List and Details screen to display them.  
  
#### To create the application  
  
1.  On the menu bar, choose **File**, **New**, **Project**.  
  
2.  In the **New Project** dialog box, expand the **LightSwitch** node, and then choose either the **LightSwitch Desktop Application (Visual Basic)** or **LightSwitch Desktop Application (Visual C#)** template.  
  
3.  In the **Name** text box, enter <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and then choose the **OK** button.  
  
4.  In the **LightSwitchInvoice Designer** window, choose the **Create New Table** link.  
  
5.  In the **Properties** window, set the value of the **Name** property to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
6.  In the entity designer, choose the **\<Add Property>** link, and then enter <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
7.  In the **Type** column, choose the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> data type.  
  
8.  On the toolbar, choose the **New Table** button.  
  
9. In the **Properties** window, set the value of the **Name** property to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
10. In the entity designer, choose the **\<Add Property>** link, and then enter <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
11. In the **Type** column, choose the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> data type.  
  
12. In the entity designer, choose the **\<Add Property>** link, and then enter <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
13. In the **Type** column, choose the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> data type.  
  
14. On the toolbar, choose the **Relationship** button.  
  
     The **Add New Relationship** dialog box appears.  
  
15. In the **To** column of the **Name** row, choose **Customer**, and then choose the **OK** button.  
  
16. In **Solution Explorer**, open the shortcut menu for **Customers**, and then choose **Open**.  
  
17. In the entity designer, choose the **\<Add Property>** link, and then enter <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
18. In the **Type** column, choose the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> data type.  
  
19. In the **Properties** window, select the **Is Computed** check box, and then choose the **Edit Method** link.  
  
20. In the code editor, add the following code for the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
21. In **Solution Explorer**, open the shortcut menu for **Screens**, and then choose **Add Screen**.  
  
22. In the **Add New Screen** dialog box, choose the **List and Details Screen** template.  
  
23. In the **Screen Data** list, choose **Customers**.  
  
24. Select the **Customer Orders** check box, and then choose the **OK** button.  
  
25. In the screen designer, on the toolbar choose the **Add Data Item** button.  
  
26. In the **Add Data Item** dialog box, choose **Local Property**, and in the Name text box enter InvoiceDate, and then choose the **OK** button.  
  
27. On the toolbar, open the **Write Code** list and choose **CustomersListDetail_Created**.  
  
28. In the code editor, add the following code for the **CustomersListDetail_Created** method:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
29. On the menu bar, choose **Debug**, **Start Debugging**.  
  
30. On the **Customers** toolbar, choose the **Add** button.  
  
     The **Add New Order** dialog box appears.  
  
31. In the **Name** text box, enter <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, and then choose the **OK** button.  
  
32. On the **Orders** toolbar, choose the **Add** button.  
  
33. In the **Order Item** text box, enter <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
34. In the **Order Amount** text box, enter <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and then choose the **OK** button.  
  
35. On the **Orders** toolbar, choose the **Add** button.  
  
36. In the **Order Item** text box, enter <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
37. In the **Order Amount** text box, enter <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and then choose the **OK** button.  
  
38. On the **Application** toolbar, choose **Save**, and then close the application.  
  
##  \<a name="SL">\</a> Create the Silverlight User Control  
 Next, you create a Silverlight user control that provides printing capabilities.  
  
#### To create a user control  
  
1.  On the menu bar, choose **File**, **Add**, **New Project**.  
  
2.  In the **New Project** dialog box, expand either the **Visual Basic** or **Visual C#** node, choose the **Silverlight** node, and then choose the **Silverlight Class Library** template.  
  
3.  In the **Name** text box, enter <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, and then choose the **OK** button.  
  
4.  In **Solution Explorer**, open the shortcut menu for **Class1.vb** or **Class1.cs**, and then choose **Delete**.  
  
5.  Open the shortcut menu for **PrintControl**, choose **Add**, and then choose **New Item**.  
  
6.  In the **Add New Item** dialog box, choose the **Silverlight User Control** template.  
  
7.  In the **Name** text box, enter <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, and then choose the **OK** button.  
  
8.  On the menu bar, choose **View**, **Toolbox**.  
  
9. In the **Toolbox** window, expand the **Common Silverlight Controls** node, choose the **DataGrid** control, and add it to the design surface.  
  
10. In the code editor, replace the existing XAML code with the following code:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     This XAML code defines the layout of the control. The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> section specifies what will appear in each column of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> (in this case, the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> fields from the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> entity).  
  
11. In **Solution Explorer**, expand the **Invoice.xaml** node, open the shortcut menu for **Invoice.xaml.vb** or **Invoice.xaml.cs**, and then choose **Open**.  
  
12. In the code editor, replace the existing code with the following code:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
13. On the menu bar, choose **Build**, **BuildSolution**.  
  
## Consume the User Control  
 Lastly, you add the user control to the [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] screen and test it.  
  
#### To add the user control  
  
1.  In **Solution Explorer**, open the shortcut menu for the **CustomersListDetail.lsml** screen, and then choose **Open**.  
  
2.  In the screen designer, choose the **Rows Layout &#124; Customer Details** node.  
  
3.  On the toolbar, open the **Add Layout Item** list, and then choose **Custom Control**.  
  
4.  In the **Add Custom Control** dialog box, choose the **Add Reference** button.  
  
5.  In the **Reference Manager** dialog box, expand the **Solution** node, select the **PrintControl** check box, and then choose the **OK** button.  
  
6.  In the **Add Custom Control** dialog box, expand the **PrintControl** nodes, choose the **Invoice** control, and then choose the **OK** button.  
  
7.  In the screen editor, choose the **Custom Control &#124; Screen Content** node, and drag it so it appears below the **Data Grid &#124; Orders** node.  
  
8.  In the **Properties** window, set the value of the **Name** property to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
9. In the **Sizing** group, choose the **Stretch** option buttons for **Horizontal Alignment** and **Vertical Alignment**.  
  
10. On the menu bar, choose **Debug**, **Start Debugging** to run the application.  
  
11. In the running application, choose the **Print** button.  
  
     When the Windows **Print** dialog box appears, you can choose a printer.  
  
## See Also  
 [Reporting and Printing in LightSwitch](../vs140/reporting-and-printing-in-lightswitch.md)