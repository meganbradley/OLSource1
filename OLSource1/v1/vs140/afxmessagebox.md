---
title: "AfxMessageBox"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFXWIN/AfxMessageBox"
  - "AfxMessageBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CString objects, formatting and message boxes"
  - "AfxMessageBox function"
ms.assetid: d66d0328-cdcc-48f6-96a4-badf089099c8
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxMessageBox
Displays a message box on the screen.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object or null-terminated string containing the message to be displayed in the message box.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The style of the message box. Apply any of the [message-box styles](../vs140/message-box-styles.md) to the box.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The Help context ID for the message; 0 indicates the application's default Help context will be used.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A unique ID used to reference a string in the string table.  
  
## Return Value  
 Zero if there is not enough memory to display the message box; otherwise, one of the following values is returned:  
  
-   **IDABORT** The Abort button was selected.  
  
-   **IDCANCEL** The Cancel button was selected.  
  
-   **IDIGNORE** The Ignore button was selected.  
  
-   **IDNO** The No button was selected.  
  
-   **IDOK** The OK button was selected.  
  
-   **IDRETRY** The Retry button was selected.  
  
-   **IDYES** The Yes button was selected.  
  
 If a message box has a Cancel button, the **IDCANCEL** value will be returned if either the ESC key is pressed or the Cancel button is selected. If the message box has no Cancel button, pressing the ESC key has no effect.  
  
 The functions [AfxFormatString1](../vs140/afxformatstring1.md) and [AfxFormatString2](../vs140/afxformatstring2.md) can be useful in formatting text that appears in a message box.  
  
## Remarks  
 The first form of this overloaded function displays a text string pointed to by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in the message box and uses <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to describe a Help context. The Help context is used to jump to an associated Help topic when the user presses the Help key (typically F1).  
  
 The second form of the function uses the string resource with the ID <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to display a message in the message box. The associated Help page is found through the value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If the default value of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is used (– 1), the string resource ID, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, is used for the Help context. For more information about defining Help contexts, see [Technical Note 28](../vs140/tn028--context-sensitive-help-support.md).  
  
## Example  
 [!code[NVC_MFCWindowing#133](../vs140/codesnippet/CPP/afxmessagebox_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CWnd::MessageBox](../vs140/cwnd--messagebox.md)