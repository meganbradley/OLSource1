---
title: "CUtlProps::OnInterfaceRequested"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CUtlProps
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnInterfaceRequested method
ms.assetid: a5e1a879-cff3-4e01-b902-2249a152984f
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CUtlProps::OnInterfaceRequested
Handles requests for an optional interface when a consumer calls a method on one of the object creation interfaces.  
  
## Syntax  
  
```  
  
      virtual HRESULT CUtlPropsBase::OnInterfaceRequested(  
   REFIID riid  
);  
```  
  
#### Parameters  
 `riid`  
 [in] The IID for the requested interface. For more details, see the description of the `riid` parameter of `ICommand::Execute` in the *OLE DB Programmer's Reference* (in the *MDAC SDK*).  
  
## Remarks  
 **OnInterfaceRequested** handles consumer requests for an optional interface when a consumer calls a method on one of the object creation interfaces (such as **IDBCreateSession**, **IDBCreateCommand**, `IOpenRowset`, or `ICommand`). It sets the corresponding OLE DB property for the requested interface. For example, if the consumer requests **IID_IRowsetLocate**, **OnInterfaceRequested** sets the **DBPROP_IRowsetLocate** interface. Doing so maintains the correct state during rowset creation.  
  
 This method is called when the consumer calls **IOpenRowset::OpenRowset** or `ICommand::Execute`.  
  
 If a consumer opens an object and requests an optional interface, the provider should set the property associated with that interface to `VARIANT_TRUE`. To allow property-specific processing, **OnInterfaceRequested** is called before the provider's **Execute** method is called. By default, **OnInterfaceRequested** handles the following interfaces:  
  
-   `IRowsetLocate`  
  
-   `IRowsetChange`  
  
-   `IRowsetUpdate`  
  
-   **IConnectionPointContainer**  
  
-   `IRowsetScroll`  
  
 If you wish to handle other interfaces, override this function in your data source, session, command, or rowset class to process functions. Your override should go through the normal set/get properties interfaces to ensure that setting properties also sets any chained properties (see [OnPropertyChanged](../vs140/cutlprops--onpropertychanged.md)).  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [CUtlProps Class](../vs140/cutlprops-class.md)