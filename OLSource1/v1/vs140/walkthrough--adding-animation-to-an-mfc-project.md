---
title: "Walkthrough: Adding Animation to an MFC Project"
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
  - "animation [MFC]"
  - "MFC, animation"
ms.assetid: 004f832c-9fd5-4f88-9ca9-ae65dececdc2
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Adding Animation to an MFC Project
This walkthrough teaches how to add a basic animated object to a Visual C++, Microsoft Foundation Class Library (MFC) project.  
  
 The walkthrough shows how to accomplish these tasks:  
  
-   Create an MFC application.  
  
-   Add a menu and then add commands to start and stop an animation.  
  
-   Create handlers for the start and stop commands.  
  
-   Add an animated object to the project.  
  
-   Center the animated object in the window.  
  
-   Verify the results.  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
## Prerequisites  
 To complete this walkthrough, you must have Visual Studio.  
  
### To create an MFC application  
  
1.  On the **File** menu, point to **New** and then click **Project**.  
  
2.  In the **New Project** dialog box, in the left pane under **Installed Templates**, expand **Visual C++** and then select **MFC**. In the middle pane, select **MFC Application**. In the **Name** box, type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Click **OK**.  
  
3.  In the **MFC Application Wizard** dialog box, verify that **Application Type** is **Multiple Documents**, **Project Style** is **Visual Studio**, and the **Document/View Architecture support** option is selected. Click **Finish**.  
  
### To add a menu and then add commands to start and stop an animation  
  
1.  On the **View** menu, point to **Other Windows** and then click **Resource View**.  
  
2.  In **Resource View**, navigate to the **Menu** folder and open it. Double-click the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> resource to open it for modification.  
  
3.  On the menu bar, in the **Type Here** box, type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to create an Animation menu.  
  
4.  Under **Animation**, in the **Type Here** box, type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to create a Start Forward command.  
  
5.  Under **Start Forward**, in the **Type Here** box, type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
6.  Under **Start Backward**, in the **Type Here** box, type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to create a Stop command.  
  
7.  Save MFCAnimationWalkthrough.rc and close it.  
  
8.  In **Solution Explorer**, double-click MainFrm.cpp to open it for modification. In the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method, locate the section that has several calls to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. Just after that section, add the following code.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
9. Save the file and close it.  
  
### To create handlers for the start and stop commands  
  
1.  On the **Project** menu, click **Class Wizard**.  
  
2.  In the **MFC Class Wizard**, under **Class name**, select <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
3.  On the **Commands** tab, in the **Object IDs** box, select <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, and then in the **Messages** box, select <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. Click **Add Handler**.  
  
4.  In the **Add Member Function** dialog box, click **OK**.  
  
5.  In the **Object IDs** box, select <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, and then in the **Messages** box, select <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. Click **Add Handler**.  
  
6.  In the **Add Member Function** dialog box, click **OK**.  
  
7.  In the **Object IDs** box, select <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, and then in the **Messages** box, select <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. Click **Add Handler** and then click **OK**.  
  
8.  In the **Add Member Function** dialog box, click **OK**.  
  
9. In the **MFC Class Wizard**, click **OK**.  
  
10. Save MFCAnimationWalkthroughView.cpp, which is open in the editor, but do not close it.  
  
### To add an animated object to the project  
  
1.  In Solution Explorer, double-click MFCAnimationWalkthroughView.h to open it for modification. Just before the definition of the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> class, add the following code to create a custom animation controller that will handle scheduling conflicts with the animation object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  At the end of the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class, add the following code.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
3.  After the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> line, add the following code.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
4.  Save the file and close it.  
  
5.  In MFCAnimationWalkthroughView.cpp, at the top of the file after the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> statements but before any class methods, add the following code.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
6.  At the end of the constructor for <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, add the following code.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
7.  Locate the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> method and then replace it with the following code.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
8.  Locate the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> method and then replace it with the following code.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
9. At the end of the file, add the following code.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
10. On the **Project** menu, click **Class Wizard**.  
  
11. In the **MFC Class Wizard**, under **Class name**, select <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
12. On the **Messages** tab, in the **Messages** box, select <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, click **Add Handler**, and then click **OK**.  
  
13. In MFCAnimationWalkthroughView.cpp, replace the implementation of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> with the following code to reduce flickering in the animated object when it is redrawn.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
14. Replace the implementations of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> with the following code.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
15. Save the file and close it.  
  
### To center the animated object in the window  
  
1.  In **Solution Explorer**, double-click MFCAnimationWalkthroughView.h to open it for modification. At the end of the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> class, just after the definition of <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, add the following code.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
2.  Save the file and close it.  
  
3.  On the **Project** menu, click **Class Wizard**.  
  
4.  In the **MFC Class Wizard**, under **Class name**, select <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
5.  On the **Messages** tab, in the **Messages** box, select <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, click **Add Handler**, and then click **OK**.  
  
6.  In MFCAnimationWalkthroughView.cpp, replace the code for <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> with the following code.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
7.  At the beginning of the constructor for <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, add the following code.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
8.  At the beginning of the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> method, add the following code.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
9. Save the file and close it.  
  
### To verify the results  
  
1.  Build and run the application. On the **Animation** menu, click **Start Forward**. A rectangle should appear and then fill the center area. When you click **Start Backward**, the animation should reverse, and when you click **Stop**, it should stop. The fill color of the rectangle should change as the animation progresses, and the current color should be displayed at the top of the animation window.  
  
## See Also  
 [Walkthroughs (MFC)](../vs140/walkthroughs--mfc-.md)