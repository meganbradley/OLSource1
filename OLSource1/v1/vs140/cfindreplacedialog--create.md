---
title: "CFindReplaceDialog::Create"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CFindReplaceDialog.Create"
  - "CFindReplaceDialog::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
  - "CFindReplaceDialog class, construction/destruction"
ms.assetid: ef346e81-bdd3-4f3e-8651-8b2145f201b8
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFindReplaceDialog::Create
Creates and displays either a Find or Find/Replace dialog box object, depending on the value of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Set this parameter to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to display a **Find** dialog box. Set it to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to display a **Find/Replace** dialog box.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to the default search string when the dialog box appears. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the dialog box does not contain a default search string.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Pointer to the default replacement string when the dialog box appears. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the dialog box does not contain a default replacement string.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 One or more flags you can use to customize the settings of the dialog box, combined using the bitwise OR operator. The default value is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, which specifies that the search is to proceed in a downward direction. See the [FINDREPLACE](http://msdn.microsoft.com/library/windows/desktop/ms646835) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information on these flags.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A pointer to the dialog box's parent or owner window. This is the window that will receive the special message indicating that a find/replace action is requested. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the main window of the application is used.  
  
## Return Value  
 Nonzero if the dialog box object was successfully created; otherwise 0.  
  
## Remarks  
 In order for the parent window to be notified of find/replace requests, you must use the Windows [RegisterWindowMessage](http://msdn.microsoft.com/library/windows/desktop/ms644947) function whose return value is a message number unique to the application's instance. Your frame window should have a message map entry that declares the callback function (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> in the example that follows) that handles this registered message. The following code fragment is an example of how to do this for a frame window class named <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>:  
  
 [!code[NVC_MFCDocView#171](../vs140/codesnippet/CPP/cfindreplacedialog--create_1.h)]  
  
 [!code[NVC_MFCDocView#172](../vs140/codesnippet/CPP/cfindreplacedialog--create_2.cpp)]  
  
 [!code[NVC_MFCDocView#173](../vs140/codesnippet/CPP/cfindreplacedialog--create_3.cpp)]  
  
 Within your <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function, you interpret the intentions of the user by using the [FindNext](../vs140/cfindreplacedialog--findnext.md) and [IsTerminating](../vs140/cfindreplacedialog--isterminating.md) methods and you create the code for the find/replace operations.  
  
## Example  
 See the example for [CFindReplaceDialog::CFindReplaceDialog](../vs140/cfindreplacedialog--cfindreplacedialog.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFindReplaceDialog Class](../vs140/cfindreplacedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFindReplaceDialog::CFindReplaceDialog](../vs140/cfindreplacedialog--cfindreplacedialog.md)