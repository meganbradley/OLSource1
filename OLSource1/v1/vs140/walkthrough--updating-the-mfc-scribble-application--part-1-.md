---
title: "Walkthrough: Updating the MFC Scribble Application (Part 1)"
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
  - "examples [C++], update existing application"
  - "ribbon UI, porting to"
  - "Office Fluent UI, porting to"
  - "samples [C++], update existing application"
  - "MFC Feature Pack, update existing application"
  - "walkthroughs [C++], update existing application"
ms.assetid: aa6330d3-6cfc-4c79-8fcb-0282263025f7
caps.latest.revision: 56
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Updating the MFC Scribble Application (Part 1)
This walkthrough demonstrates how to modify an existing MFC application to use the Ribbon user interface. Visual Studio supports both the Office 2007 Ribbon and the Windows 7 Scenic Ribbon. For more information about the Ribbon user interface, see [Ribbons](http://go.microsoft.com/fwlink/?LinkId=129233) on the MSDN Web site.  
  
 This walkthrough modifies the classic Scribble 1.0 MFC sample that lets you use the mouse to create line drawings. This part of the walkthrough shows how to modify the Scribble sample so that it displays a ribbon bar. [Part 2](../vs140/walkthrough--updating-the-mfc-scribble-application--part-2-.md) adds more buttons to the ribbon bar.  
  
## Prerequisites  
 [SCRIBBLE Sample: MFC MDI Drawing Application](../vs140/visual-c---samples.md)  
  
 [RibbonGadgets Sample: Ribbon Gadgets Application](../vs140/visual-c---samples.md)  
  
##  \<a name="top">\</a> Sections  
 This part of the walkthrough has the following sections:  
  
-   [Replacing the Base Classes](#replaceClass)  
  
-   [Adding Bitmaps to the Project](#addBitmap)  
  
-   [Adding a Ribbon Resource to the Project](#addRibbon)  
  
-   [Creating an Instance of the Ribbon Bar](#createInstance)  
  
-   [Adding a Ribbon Category](#addCategory)  
  
-   [Setting the Look of the Application](#setLook)  
  
##  \<a name="replaceClass">\</a> Replacing the Base Classes  
 To convert an application that supports a menu to an application that supports a ribbon, you must derive the application, frame window, and toolbar classes from updated base classes. (We suggest that you do not modify the original Scribble sample; instead, clean the Scribble project, copy it to another directory, and then modify the copy.)  
  
#### To replace the base classes in the Scribble application  
  
1.  In scribble.cpp, verify that <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> includes a call to [AfxOleInit](../vs140/afxoleinit.md).  
  
2.  Add the following code to the stdafx.h file.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  In scribble.h, modify the definition for the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class so that it is derived from [CWinAppEx](../vs140/cwinappex-class.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
4.  Scribble 1.0 was written when Windows applications used an initialization (.ini) file to save user preference data. Instead of an initialization file, modify Scribble to store user preferences in the registry. To set the registry key and base, type the following code in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> after the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
5.  The main frame for a multiple document interface (MDI) application is no longer derived from the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class. Instead, it is derived from the [CMDIFrameWndEx](../vs140/cmdiframewndex-class.md) class.  
  
     In the mainfrm.h and mainfrm.cpp files, replace all references to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
6.  In the childfrm.h and childfrm.cpp files, replace <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
     In the childfrm. h file, replace <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
7.  Modify toolbars and status bars to use the new MFC classes.  
  
     In the mainfrm.h file:  
  
    1.  Replace <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
    2.  Replace <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
8.  In the mainfrm.cpp file:  
  
    1.  Replace <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
    2.  Replace <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
    3.  Replace <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
9. In the ipframe.cpp file, comment out the following three lines of code.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
10. If you intend to link your application statically, add the following code to the start of the project resource (.rc) file.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     The afxribbon.rc file contains resources that are required at run time. The [MFC Application Wizard](../vs140/mfc-application-wizard.md) includes this file automatically when you create an application.  
  
11. Save the changes and then build and run the application.  
  
 [[go to top](#top)]  
  
##  \<a name="addBitmap">\</a> Adding Bitmaps to the Project  
 The next four steps of this walkthrough require bitmap resources. You can obtain appropriate bitmaps in various ways:  
  
-   Use the [Resource Editors](../vs140/resource-editors.md) to invent your own bitmaps. Or use the resource editors to assemble bitmaps from the portable network graphics (.png) images that are included with [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. These images are in the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> directory.  
  
     However, the Ribbon user interface requires that certain bitmaps support transparent images. Transparent bitmaps use 32-bit pixels, where 24 bits specify the red, green, and blue components of the color, and 8 bits define an *alpha channel* that specifies the transparency of the color. The current resource editors can view, but not modify bitmaps with 32-bit pixels. Consequently, use an external image editor instead of the resource editors to manipulate transparent bitmaps.  
  
-   Copy an appropriate resource file from another application to your project and then import bitmaps from that file.  
  
 This walkthrough copies resource files from an application in the Samples directory.  
  
#### To add bitmaps to the Project  
  
1.  Use File Explorer to copy the following .bmp files from the resources directory (<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>) of the RibbonGadgets sample:  
  
    1.  Copy main.bmp to your Scribble project.  
  
    2.  Copy filesmall.bmp and filelarge.bmp to your Scribble project.  
  
    3.  Make new copies of the filelarge.bmp and filesmall.bmp files, but save the copies in the RibbonGadgets sample. Rename the copies homesmall.bmp and homelarge.bmp and then move the copies to your Scribble project.  
  
    4.  Make a copy of the toolbar.bmp file, but save the copy in the RibbonGadgets sample. Rename the copy panelicons.bmp and then move the copy to your Scribble project.  
  
2.  Import the bitmap for an MFC application. In **Resource View**, double-click the **scribble.rc** node, double-click the **Bitmap** node, and then click **Add resource**. On the dialog box that appears, click **Import**. Browse to the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> directory, select the main.bmp file, and then click **Open**.  
  
     The main.bmp bitmap contains a 26x26 image. Change the ID of the bitmap to IDB_RIBBON_MAIN.  
  
3.  Import the bitmaps for the file menu that is attached to the Application button.  
  
    1.  Import the filesmall.bmp file, which contains ten 16x16 (16x160) images. Because we need only eight 16x16 images (16x128),  use the **Resource View** to change the width of that bitmap from 160 to 128. Change the ID of the bitmap to IDB_RIBBON_FILESMALL.  
  
    2.  Import the filelarge.bmp, which contains eight 32x32 (32x256) images. Change the ID of the bitmap to IDB_RIBBON_FILELARGE.  
  
4.  Import the bitmaps for the ribbon categories and panels. Each tab on the ribbon bar is a category, and consists of a text label and an optional image.  
  
    1.  Import the homesmall.bmp bitmap, which contains eight 16x16 images for small button bitmaps. Change the ID of the bitmap to IDB_RIBBON_HOMESMALL.  
  
    2.  Import the homelarge.bmp bitmap, which contains eight 32x32 images for large button bitmaps. Change the ID of the bitmap to IDB_RIBBON_HOMELARGE.  
  
5.  Import bitmaps for the resized ribbon panels. These bitmaps, or panel icons, are used after a resize operation if the ribbon is too small to display the entire panel.  
  
    1.  Import the panelicons.bmp bitmap, which contains eight 16x16 images. In the **Properties** window of the **Bitmap Editor**, adjust the width of the bitmap to 64 (16x64). Change the ID of the bitmap to IDB_PANEL_ICONS.  
  
 [[go to top](#top)]  
  
##  \<a name="addRibbon">\</a> Adding a Ribbon Resource to the Project  
 When you convert an application that uses menus to an application that uses a ribbon, you do not have to remove or disable the existing menus. Instead, you create a ribbon resource, add ribbon buttons, and then associate the new buttons with the existing menu items. Although the menus are no longer visible, messages from the ribbon bar are routed through the menus. In addition, menu shortcuts continue to work.  
  
 A ribbon consists of the Application button, which is the large button on the upper-left side of the ribbon, and one or more category tabs. Each category tab contains one or more panels that act as containers for ribbon buttons and controls. The following procedure shows how to create a ribbon resource and then customize the Application button.  
  
#### To add a ribbon resource to the project  
  
1.  On the **Project** menu, click **Add Resource**.  
  
2.  In the **Add Resource** dialog box, select **Ribbon** and then click **New**.  
  
     Visual Studio creates a ribbon resource and opens it in the design view. The ribbon resource ID is IDR_RIBBON1, which is displayed in **Resource View**. The ribbon contains one category and one panel.  
  
3.  You can customize the Application button by modifying its properties. The message IDs that are used in this code are already defined in the menu for Scribble 1.0.  
  
4.  In the design view, click the Application Button to display its properties. Change property values as follows: **Image** to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, **Prompt** to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, **Keys** to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, **Large Images** to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, and **Small Images** to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
5.  The following modifications create the menu that appears when the user clicks the Application button. Click the ellipsis (**...**) next to **Main Items** to open the **Items Editor**.  
  
    1.  Click **Add** to add a button. Change **Caption** to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, **ID** to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, **Image** to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, **Image Large** to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
    2.  Click **Add** to add a second button. Change **Caption** to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, **ID** to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, **Image** to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, and **Image Large** to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
    3.  Click **Add** to add a third button. Change **Caption** to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, **ID** to <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, **Image** to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, and **Image Large** to <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
    4.  Click **Add** to add a fourth  button. Change **Caption** to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, **ID** to <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, **Image** to <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, and **Image Large** to <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
    5.  Change the **Item** type to **Separator** and then click **Add**.  
  
    6.  Change the **Item** type to **Button**. Click **Add** to add a fifth button. Change **Caption** to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, **ID** to <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, **Image** to <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, and **Image Large** to <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
6.  The following modifications create a submenu under the Print button that you created in the previous step.  
  
    1.  Click the **Print** button, change the **Item** type to **Label**, and then click **Insert**. Change **Caption** to <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
    2.  Click the **Print** button, change the **Item** type to **Button**, and click **Insert**. Change **Caption** to <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, **ID** to <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, **Image** to <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, and **Image Large** to <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
    3.  Click the **Print** button and then click **Insert** to add a button. Change **Caption** to <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, **ID** to <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, **Image** to <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, and **Image Large** to <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
    4.  Click the **Print** button and then click **Insert** to add another button. Change **Caption** to <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, **ID** to <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, **Image** to <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, and **Image Large** to<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
    5.  You have now modified the **Main Items**. Click **Close** to exit the **Items Editor**.  
  
7.  The following modification creates an exit button that appears at the bottom of the Application button menu.  
  
    1.  In the **Properties** window, click the ellipsis (**...**) next to **Button** to open the **Items Editor**.  
  
    2.  Click **Add** to add a button. Change **Caption** to <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, **ID** to <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, **Image** to<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.  
  
 [[go to top](#top)]  
  
##  \<a name="createInstance">\</a> Creating an Instance of the Ribbon Bar  
 The following steps show how to create an instance of the ribbon bar when your application starts. To add a ribbon bar to an application, declare the ribbon bar in the mainfrm.h file. Then, in the mainfrm.cpp file, write code to load the ribbon resource.  
  
#### To create an instance of the ribbon bar  
  
1.  In the mainfrm.h file, add a data member to the protected section of <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, the class definition for the main frame. This member represents the ribbon bar.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
2.  In the mainfrm.cpp file, add the following code before the final <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> statement at the end of the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> function. This creates an instance of the ribbon bar.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [[go to top](#top)]  
  
##  \<a name="addCategory">\</a> Customizing the Ribbon Resource  
 Now that you have created the Application button, you can add elements to the ribbon.  
  
> [!NOTE]
>  This walkthrough uses the same panel icon for all panels. However, you can use other image list indexes to display other icons.  
  
#### To add a Home category and Edit panel  
  
1.  The Scribble program requires only one category. In the design view, click **Category** to display its properties. Change property values as follows: **Caption** to <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, **Large Images** to <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, **Small Images** to <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
2.  Each ribbon category is organized into named panels. Each panel contains a set of controls that perform related operations. This category has one panel. Click **Panel**, and then change **Caption** to <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> and **Image Index** to <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
3.  To the **Edit** panel, add a button that is responsible for clearing the contents of the document. The message ID for this button has already been defined in the IDR_SCRIBBTYPE menu resource. Specify <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> as the button text and the index of the bitmap that decorates the button. Open the **Toolbox**, and then drag a **Button** to the **Edit** panel. Click the button  and then change **Caption** to <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, **ID** to <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, **Image Index** to <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>, **Large Image Index** to <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
4.  Save the changes, and then build and run the application. The Scribble application should be displayed, and it should have a ribbon bar at the top of the window instead of a menu bar. The ribbon bar should have one category, **Home**, and **Home** should have one panel, **Edit**. The ribbon buttons that you added should be associated with the existing event handlers, and the **Open**, **Close**, **Save**, **Print**, and **Clear All** buttons should work as expected.  
  
 [[go to top](#top)]  
  
##  \<a name="setLook">\</a> Setting the Look of the Application  
 A *visual manager* is a global object that controls all drawing for an application. Because the original Scribble application uses the Office 2000 user interface (UI) style, the application may look old-fashioned. You can reset the application to use the Office 2007 visual manager so that it resembles an Office 2007 application.  
  
#### To set the look of the application  
  
1.  In the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> function, type the following code to change the default visual manager and style.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
2.  Save the changes, and then build and run the application. The application UI should resemble the Office 2007 UI.  
  
 [[go to top](#top)]  
  
## Next Steps  
 You have modified the classic Scribble 1.0 MFC sample to use the Ribbon Designer. Now go to [Part 2](../vs140/walkthrough--updating-the-mfc-scribble-application--part-2-.md).  
  
## See Also  
 [Walkthroughs (MFC Next)](../vs140/walkthroughs--mfc-.md)   
 [Walkthrough: Updating the MFC Scribble Application (Part 2)](../vs140/walkthrough--updating-the-mfc-scribble-application--part-2-.md)