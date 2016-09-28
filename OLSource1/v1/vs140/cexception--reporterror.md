---
title: "CException::ReportError"
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
  - "ReportError"
  - "CException.ReportError"
  - "CException::ReportError"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReportError method"
  - "CException class, operations"
ms.assetid: b816e4d6-6699-4e64-8011-e57cc9355a03
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CException::ReportError
Call this member function to report error text in a message box to the user.  
  
## Syntax  
  
```  
  
      virtual int ReportError(  
   UINT nType = MB_OK,  
   UINT nMessageID = 0   
);  
```  
  
#### Parameters  
 `nType`  
 Specifies the style of the message box. Apply any combination of the [message-box styles](../vs140/message-box-styles.md) to the box. If you don't specify this parameter, the default is **MB_OK**.  
  
 *nMessageID*  
 Specifies the resource ID (string table entry) of a message to display if the exception object does not have an error message. If 0, the message "No error message is available" is displayed.  
  
## Return Value  
 An `AfxMessageBox` value; otherwise 0 if there is not enough memory to display the message box. See [AfxMessageBox](../vs140/afxmessagebox.md) for the possible return values.  
  
## Example  
 Here is an example of the use of `CException::ReportError`. For another example, see the example for [CATCH](../vs140/catch.md).  
  
 [!code[NVC_MFCExceptions#23](../vs140/codesnippet/CPP/cexception--reporterror_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CException Class](../vs140/cexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [AfxMessageBox](../vs140/afxmessagebox.md)   
 [CFileException::GetErrorMessage](../vs140/cfileexception--geterrormessage.md)