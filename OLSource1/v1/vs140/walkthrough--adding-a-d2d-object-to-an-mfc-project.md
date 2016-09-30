---
title: "Walkthrough: Adding a D2D Object to an MFC Project"
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
  - "MFC, D2D"
  - "D2D [MFC]"
ms.assetid: dda36c33-c231-4da6-a62f-72d69a12b6dd
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Adding a D2D Object to an MFC Project
This walkthrough teaches how to add a basic Direct2D (D2D) object to a Visual C++, Microsoft Foundation Class Library (MFC) project, and then build the project into an application that prints "Hello, world" on a gradient background.  
  
 The walkthrough shows how to accomplish these tasks:  
  
-   Create an MFC application.  
  
-   Create a solid-color brush and a linear-gradient brush.  
  
-   Modify the gradient brush so that it will change appropriately when the window is resized.  
  
-   Implement a D2D drawing handler.  
  
-   Verify the results.  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
## Prerequisites  
 To complete this walkthrough, you must have Visual Studio.  
  
### To create an MFC application  
  
1.  On the **File** menu, point to **New** and then click **Project**.  
  
2.  In the **New Project** dialog box, in the left pane under **Installed Templates**, expand **Visual C++** and then select **MFC**. In the middle pane, select **MFC Application**. In the **Name** box, type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Click **OK**.  
  
3.  In the **MFC Application Wizard**, click **Finish** without changing any settings.  
  
### To create a solid-color brush and a linear-gradient brush  
  
1.  In **Solution Explorer**, in the **MFCD2DWalkthrough** project, in the **Header Files** folder, open MFCD2DWalkthroughView.h. Add the following code to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class to create three data variables.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     Save the file and close it.  
  
2.  In the **Source Files** folder, open MFCD2DWalkthroughView.cpp. In the constructor for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class, add the following code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     Save the file and close it.  
  
### To modify the gradient brush so that it will change appropriately when the window is resized  
  
1.  On the **Project** menu, click **Class Wizard**.  
  
2.  In the **MFC Class Wizard**, under **Class name**, select <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
3.  On the **Messages** tab, in the **Messages** box, select <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and then click **Add Handler**. This action adds the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> message handler to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class.  
  
4.  In the **Existing handlers** box, select <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Click **Edit Code** to display the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method. At the end of the method, add the following code.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     Save the file and close it.  
  
### To implement a D2D drawing handler  
  
1.  On the **Project** menu, click **Class Wizard**.  
  
2.  In the **MFC Class Wizard**, under **Class name**, select <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
3.  On the **Messages** tab, click **Add Custom Message**.  
  
4.  In the **Add Custom Message** dialog box, in the **Custom Windows Message** box, type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. In the **Message handler name** box, type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Select the **Registered Message** option and then click **OK**. This action adds a message handler for the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> message to the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class.  
  
5.  In the **Existing handlers** box, select <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. Click **Edit Code** to display the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method. Use the following code for the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     Save the file and close it.  
  
### To verify the results  
  
1.  Build and run the application. It should have a gradient rectangle that changes when you resize the window. “Hello World!” should be displayed in the center of the rectangle.  
  
## See Also  
 [Walkthroughs (MFC)](../vs140/walkthroughs--mfc-.md)