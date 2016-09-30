---
title: "Walkthrough: Updating the MFC Scribble Application (Part 2)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "walkthroughs [C++]"
ms.assetid: 602df5c2-17d4-4cd9-8cf6-dff652c4cae5
caps.latest.revision: 38
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Updating the MFC Scribble Application (Part 2)
[Part 1](../vs140/walkthrough--updating-the-mfc-scribble-application--part-1-.md) of this walkthrough showed how to add an Office Fluent Ribbon to the classic Scribble application. This part shows how to add ribbon panels and controls that users can use instead of menus and commands.  
  
## Prerequisites  
 [Scribble Sample: MFC MDI Drawing Application](../vs140/visual-c---samples.md)  
  
##  \<a name="top">\</a> Sections  
 This part of the walkthrough has the following sections:  
  
-   [Adding New Panels to the Ribbon](#addNewPanel)  
  
-   [Adding a Help Panel to the Ribbon](#addHelpPanel)  
  
-   [Adding a Pen Panel to the Ribbon](#addPenPanel)  
  
-   [Adding a Color Button to the Ribbon](#addColorButton)  
  
-   [Adding a Color Member to the Document Class](#addColorMember)  
  
-   [Initializing Pens and Saving Preferences](#initPenSave)  
  
##  \<a name="addNewPanel">\</a> Adding New Panels to the Ribbon  
 These steps show how to add a **View** panel that contains two check boxes that control the visibility of the toolbar and the status bar, and also a **Window** panel that contains a vertically oriented split button that controls the creation and arrangement of multiple-document interface (MDI) windows.  
  
#### To add a View panel and Window panel to the ribbon bar  
  
1.  Create a panel named <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, which has two check boxes that toggle the status bar and toolbar.  
  
    1.  From the **Toolbox**, drag a **Panel** to the **Home** category. Then drag two **Check Boxes** to the panel.  
  
    2.  Click the panel to modify its properties. Change **Caption** to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
    3.  Click the first check box to modify its properties. Change **ID** to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and **Caption** to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
    4.  Click the second check box to modify its properties. Change **ID** to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and **Caption** to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
2.  Create a panel named <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> that has a split button. When a user clicks the split button, a shortcut menu displays three commands that are already defined in the Scribble application.  
  
    1.  From the **Toolbox**, drag a **Panel** to the **Home** category. Then drag a **Button** to the panel.  
  
    2.  Click the panel to modify its properties. Change **Caption** to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
    3.  Click the button. Change **Caption** to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, **Keys** to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, **Large Image Index** to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, and **Split Mode** to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. Then click the ellipsis (**...**) next to **Menu Items** to open the **Items Editor** dialog box.  
  
    4.  Click **Add** three times to add three buttons.  
  
    5.  Click the first button and then change **Caption** to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, and **ID** to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
    6.  Click the second button and then change **Caption** to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, and **ID** to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
    7.  Click the third button and then change **Caption** to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, and **ID** to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
3.  Save the changes, and then build and run the application. The **View** and **Window** panels should be displayed. Click the buttons to confirm that they function correctly.  
  
 [[go to top](#top)]  
  
##  \<a name="addHelpPanel">\</a> Adding a Help Panel to the Ribbon  
 Now, you can assign two menu items that are defined in the Scribble application to ribbon buttons that are named **Help Topics** and **About Scribble**. The buttons are added to a new panel named **Help**.  
  
#### To add a Help panel  
  
1.  From the **Toolbox**, drag a **Panel** to the **Home** category. Then drag two **Buttons** to the panel.  
  
2.  Click the panel to modify its properties. Change **Caption** to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
3.  Click the first button. Change **Caption** to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, and **ID** to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
4.  Click the second button. Change **Caption** to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, and **ID** to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
5.  Save the changes, and then build and run the application. A **Help** panel that contains two ribbon buttons should be displayed.  
  
    > [!IMPORTANT]
    >  When you click the **Help Topics** button, the Scribble application opens a compressed HTML (.chm) help file named *your_project_name*.chm. Consequently, if your project is not named Scribble, you must rename the help file to your project name.  
  
 [[go to top](#top)]  
  
##  \<a name="addPenPanel">\</a> Adding a Pen Panel to the Ribbon  
 Now, add a panel to display buttons that control the thickness and the color of the pen. This panel contains a check box that toggles between thick and thin pens. Its functionality resembles that of the **Thick Line** menu item in the Scribble application.  
  
 The original Scribble application lets the user select pen widths from a dialog box that appears when the user clicks **Pen Widths** on the menu. Because the ribbon bar has ample room for new controls, you can replace the dialog box by using two combo boxes on the ribbon. One combo box adjusts the width of the thin pen and the other combo box adjusts the width of the thick pen.  
  
#### To add a Pen panel and combo boxes to the ribbon  
  
1.  From the **Toolbox**, drag a **Panel** to the **Home** category. Then drag a **Check Box** and two **Combo Boxes** to the panel.  
  
2.  Click the panel to modify its properties. Change **Caption** to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
3.  Click the check box. Change **Caption** to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, and **ID** to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
4.  Click the first combo box. Change **Caption** to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, **ID** to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, **Text** to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, **Type** to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, and **Data** to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
5.  Click the second combo box. Change **Caption** to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, **ID** to <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, **Text** to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, **Type** to <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, and **Data** to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
6.  The new combo boxes do not correspond to any existing menu items. Therefore, you must create a menu item for every pen option.  
  
    1.  In the **Resource View** window, open the IDR_SCRIBBTYPE menu resource.  
  
    2.  Click **Pen** to open the p**en** menu. Then click **Type Here** and type <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
    3.  Right-click the text that you just typed to open the **Properties** window, and then change the ID property to <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
    4.  You must also create an event handler for every pen menu item. Right-click the **Thi&n Pen** menu item that you just created and then click **Add Event Handler**. The **Event Handler Wizard** is displayed.  
  
    5.  In the **Class list** box in the wizard, select **CScribbleDoc** and then click **Add and Edit**. This creates an event handler named <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
    6.  Add the following code to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
7.  Next, create a menu item and event handlers for the thick pen.  
  
    1.  In the **Resource View** window, open the IDR_SCRIBBTYPE menu resource.  
  
    2.  Click **Pen** to open the pen menu. Then click **Type Here** and type <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
    3.  Right-click the text that you just typed to display the **Properties** window. Change the ID property to <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
    4.  Right-click the **Thick Pen** menu item that you just created and then click **Add Event Handler**. The **Event Handler Wizard** is displayed.  
  
    5.  In the **Class list** box of the wizard, select **CScribbleDoc** and then click **Add and Edit**. This creates an event handler named <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
    6.  Add the following code to <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
8.  Save the changes, and then build and run the application. New buttons and combo boxes should be displayed. Try using different pen widths to scribble.  
  
 [[go to top](#top)]  
  
##  \<a name="addColorButton">\</a> Adding a Color Button to the Pen Panel  
 Next, add a [CMFCRibbonColorButton](../vs140/cmfcribboncolorbutton-class.md) object that lets the user scribble in color.  
  
#### To add a color button to the Pen panel  
  
1.  Before you add the color button, create a menu item for it. In the **Resource View** window, open the IDR_SCRIBBTYPE menu resource. Click the **Pen** menu item to open the pen menu. Then click **Type Here** and type <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>. Right-click the text that you just typed to display the **Properties** window. Change the ID to <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
2.  Now add the color button. From the **Toolbox**, drag a **Color Button** to the **Pen** panel.  
  
3.  Click the color button. Change **Caption** to <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, **ID** to <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, **SimpleLook** to <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, **Large Image Index** to <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, and **Split Mode** to <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
4.  Save the changes, and then build and run the application. The new color button should be displayed on the **Pen** panel. However, it cannot be used because it does not yet have an event handler. The next steps show how to add an event handler for the color button.  
  
 [[go to top](#top)]  
  
##  \<a name="addColorMember">\</a> Adding a Color Member to the Document Class  
 Because the original Scribble application does not have color pens, you must write an implementation for them. To store the pen color of the document, add a new member to the document class, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  
#### To add a color member to the document class  
  
1.  In scribdoc.h, in the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> class, find the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> section. Add the following lines of code after the definition of the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> data member.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
2.  Every document contains a list of stokes that the user has already drawn. Every stroke is defined by a <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> class does not include information about pen color. Therefore, you must modify the class. In scribdoc.h, in the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> class, add the following lines of code after the definition of the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> data member.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
3.  In scribdoc.h, add a new <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> constructor whose parameters specify a width and color. Add the following line of code after the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
4.  In scribdoc.cpp, add the implementation of the new <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> constructor. Add the following code after the implementation of the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> constructor.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
5.  Change the second line of the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> method as follows.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
6.  Set the default pen color for the document class. In scribdoc.cpp, add the following lines to <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, after the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
7.  In scribdoc.cpp, change the first line of the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> method to the following.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
8.  Change the last line of the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> method to the following.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
9. You added the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> member in a previous step. Now, create an event handler for the color button that sets the member.  
  
    1.  In the **Resource View** window, open the IDR_SCRIBBTYPE menu resource.  
  
    2.  Right-click the **Color** menu item and click **Add Event Handler…**. The **Event Handler Wizard** appears.  
  
    3.  In the **Class list** box in the wizard, select **CScribbleDoc** and then click the **Add and Edit** button. This creates the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> event handler stub.  
  
10. Replace the stub for the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> event handler with the following code.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
11. Save the changes and then build and run the application. You should be able to press the color button and change the pen's color.  
  
 [[go to top](#top)]  
  
##  \<a name="initPenSave">\</a> Initializing Pens and Saving Preferences  
 Next, initialize the color and width of the pens. Finally, save and load a color drawing from a file.  
  
#### To initialize controls on the ribbon bar  
  
1.  Initialize the pens on the ribbon bar.  
  
     Add the following code to scribdoc.cpp, in the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> method, after the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
2.  Save a color drawing to a file. Add the following statement to scribdoc.cpp, in the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> method, after the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
3.  Finally, load a color drawing from a file. Add the following line of code, in the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> method, after the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
4.  Now scribble in color and save your drawing to a file.  
  
 [[go to top](#top)]  
  
## Conclusion  
 You have updated the MFC Scribble application. Use this walkthrough as a guide when you modify your existing applications.  
  
## See Also  
 [Walkthroughs (MFC Next)](../vs140/walkthroughs--mfc-.md)   
 [Walkthrough: Updating the MFC Scribble Application (Part 1)](../vs140/walkthrough--updating-the-mfc-scribble-application--part-1-.md)