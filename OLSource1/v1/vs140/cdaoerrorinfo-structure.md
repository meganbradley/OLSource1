---
title: "CDaoErrorInfo Structure"
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
  - "CDaoErrorInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoErrorInfo structure"
  - "DAO (Data Access Objects), Errors collection"
ms.assetid: cd37ef71-b0b3-401d-bc2b-540c9147f532
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoErrorInfo Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure contains information about an error object defined for data access objects (DAO).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *m_lErrorCode*  
 A numeric DAO error code. See the topic "Trappable Data Access Errors" in DAO Help.  
  
 *m_strSource*  
 The name of the object or application that originally generated the error. The Source property specifies a string expression representing the object that originally generated the error; the expression is usually the object's class name. For details, see the topic "Source Property" in DAO Help.  
  
 *m_strDescription*  
 A descriptive string associated with an error. For details, see the topic "Description Property" in DAO Help.  
  
 *m_strHelpFile*  
 A fully qualified path to a Microsoft Windows Help file. For details, see the topic "HelpContext, HelpFile Properties" in DAO Help.  
  
 *m_lHelpContext*  
 A context ID for a topic in a Microsoft Windows Help file. For details, see the topic "HelpContext, HelpFile Properties" in DAO Help.  
  
## Remarks  
 MFC does not encapsulate DAO error objects in a class. Instead, the [CDaoException](../vs140/cdaoexception-class.md) class supplies an interface for accessing the Errors collection contained in the DAO **DBEngine** object, the object that also contains all workspaces. When an MFC DAO operation throws a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that you catch, MFC fills a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure and stores it in the exception object's [m_pErrorInfo](../vs140/cdaoexception--m_perrorinfo.md) member. (If you choose to call DAO directly, you must call the exception object's [GetErrorInfo](../vs140/cdaoexception--geterrorinfo.md) member function yourself to fill <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.)  
  
 For more information about handling DAO errors, see the article [Exceptions: Database Exceptions](../vs140/exceptions--database-exceptions.md). For related information, see the topic "Error Object" in DAO Help.  
  
 Information retrieved by the [CDaoException::GetErrorInfo](../vs140/cdaoexception--geterrorinfo.md) member function is stored in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure. Examine the [m_pErrorInfo](../vs140/cdaoexception--m_perrorinfo.md) data member from a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that you catch in an exception handler, or call <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> from a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object that you create explicitly in order to check errors that might have occurred during a direct call to the DAO interfaces. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> also defines a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member function in debug builds. You can use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to dump the contents of a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CDaoException Class](../vs140/cdaoexception-class.md)