---
title: "IMPLEMENT_OLECREATE_FLAGS"
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
  - "afxRegInsertable"
  - "IMPLEMENT_OLECREATE_FLAGS"
  - "AFXDISP/IMPLEMENT_OLECREATE_FLAGS"
  - "afxRegApartmentThreading"
  - "afxRegFreeThreading"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "afxRegApartmentThreading constant"
  - "afxRegInsertable constant"
  - "afxRegFreeThreading constant"
  - "IMPLEMENT_OLECREATE_FLAGS macro"
ms.assetid: d1589f6a-5a69-4742-b07c-4c621cfd040d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IMPLEMENT_OLECREATE_FLAGS
Either this macro or [IMPLEMENT_OLECREATE](../vs140/implement_olecreate.md) must appear in the implementation file for any class that uses `DECLARE_OLECREATE`.  
  
## Syntax  
  
```  
  
IMPLEMENT_OLECREATE_FLAGS(  
class_name  
,   
external_name  
,   
nFlags  
,   
l  
,   
w1  
,   
w2  
,   
b1  
,   
b2  
,   
b3  
,   
b4  
,   
b5  
,   
b6  
,   
b7  
,   
b8  
 )  
  
```  
  
#### Parameters  
 *class_name*  
 The actual name of the class.  
  
 *external_name*  
 The object name exposed to other applications (enclosed in quotation marks).  
  
 `nFlags`  
 Contains one or more of the following flags:  
  
-   `afxRegInsertable` Allows the control to appear in the Insert Object dialog box for OLE objects.  
  
-   `afxRegApartmentThreading` Sets the threading model in the registry to ThreadingModel=Apartment.  
  
-   **afxRegFreeThreading** Sets the threading model in the registry to ThreadingModel=Free.  
  
     You can combine the two flags `afxRegApartmentThreading` and `afxRegFreeThreading` to set ThreadingModel=Both. See [InprocServer32](http://msdn.microsoft.com/library/windows/desktop/ms682390) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information on threading model registration.  
  
 *l*, *w1*, *w2*, *b1*, *b2*, *b3*, *b4*, *b5*, *b6*, *b7*, *b8*  
 Components of the class's **CLSID**.  
  
## Remarks  
  
> [!NOTE]
>  If you use `IMPLEMENT_OLECREATE_FLAGS`, you can specify which threading model your object supports by using the `nFlags` parameter. If you want to support only the single-treading model, use `IMPLEMENT_OLECREATE`.  
  
 The external name is the identifier exposed to other applications. Client applications use the external name to request an object of this class from an automation server.  
  
 The OLE class ID is a unique 128-bit identifier for the object. It consists of one **long**, two **WORD**s, and eight **BYTE**s, as represented by *l*, *w1*, *w2*, and *b1* through *b8* in the syntax description. The Application Wizard and code wizards create unique OLE class IDs for you as required.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DECLARE_OLECREATE](../vs140/declare_olecreate.md)   
 [CLSID Key](http://msdn.microsoft.com/library/windows/desktop/ms691424)