---
title: "AfxOleRegisterServerClass"
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
  - "OAT_SERVER"
  - "OAT_CONTAINER"
  - "AFXDISP/AfxOleRegisterServerClass"
  - "OAT_INPLACE_SERVER"
  - "OAT_DISPATCH_OBJECT"
  - "AfxOleRegisterServerClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxOleRegisterServerClass function"
  - "OAT_CONTAINER constant"
  - "OAT_DISPATCH_OBJECT constant"
  - "OAT_SERVER constant"
  - "OAT_INPLACE_SERVER constant"
  - "application control"
ms.assetid: 671406dc-b0b5-4523-89da-50b799c4d22c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxOleRegisterServerClass
This function allows you to register your server in the OLE system registry.  
  
## Syntax  
  
```  
  
      BOOL AFXAPI AfxOleRegisterServerClass(  
   REFCLSID clsid,  
   LPCTSTR lpszClassName,  
   LPCTSTR lpszShortTypeName,  
   LPCTSTR lpszLongTypeName,  
   OLE_APPTYPE nAppType = OAT_SERVER,  
   LPCTSTR* rglpszRegister = NULL,  
   LPCTSTR* rglpszOverwrite = NULL   
);  
```  
  
#### Parameters  
 `clsid`  
 Reference to the server's OLE class ID.  
  
 `lpszClassName`  
 Pointer to a string containing the class name of the server's objects.  
  
 *lpszShortTypeName*  
 Pointer to a string containing the short name of the server's object type, such as "Chart."  
  
 *lpszLongTypeName*  
 Pointer to a string containing the long name of the server's object type, such as "Microsoft Excel 5.0 Chart."  
  
 `nAppType`  
 A value, taken from the **OLE_APPTYPE** enumeration, specifying the type of OLE application. Possible values are the following:  
  
-   `OAT_INPLACE_SERVER` Server has full server user-interface.  
  
-   `OAT_SERVER` Server supports only embedding.  
  
-   `OAT_CONTAINER` Container supports links to embeddings.  
  
-   `OAT_DISPATCH_OBJECT` `IDispatch`-capable object.  
  
 `rglpszRegister`  
 Array of pointers to strings representing the keys and values to be added to the OLE system registry if no existing values for the keys are found.  
  
 `rglpszOverwrite`  
 Array of pointers to strings representing the keys and values to be added to the OLE system registry if the registry contains existing values for the given keys.  
  
## Return Value  
 Nonzero if the server class is successfully registered; otherwise 0.  
  
## Remarks  
 Most applications can use **COleTemplateServer::Register** to register the application's document types. If your application's system-registry format does not fit the typical pattern, you can use `AfxOleRegisterServerClass` for more control.  
  
 The registry consists of a set of keys and values. The `rglpszRegister` and `rglpszOverwrite` arguments are arrays of pointers to strings, each consisting of a key and a value separated by a **NULL** character (`'\0'`). Each of these strings can have replaceable parameters whose places are marked by the character sequences `%1` through `%5`.  
  
 The symbols are filled in as follows:  
  
|Symbol|Value|  
|------------|-----------|  
|%1|Class ID, formatted as a string|  
|%2|Class name|  
|%3|Path to executable file|  
|%4|Short type name|  
|%5|Long type name|  
  
## Requirements  
 **Header:** \<afxdisp.h>  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleTemplateServer::UpdateRegistry](../vs140/coletemplateserver--updateregistry.md)