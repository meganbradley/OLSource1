---
title: "IRowsetUpdateImpl Class"
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
  - "IRowsetUpdateImpl"
  - "ATL.IRowsetUpdateImpl"
  - "ATL::IRowsetUpdateImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "providers, updatable"
  - "IRowsetUpdateImpl class"
  - "updatable providers, deferred update"
ms.assetid: f85af76b-ab6f-4f8b-8f4a-337c9679d68f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetUpdateImpl Class
The OLE DB Templates implementation of the [IRowsetUpdate](https://msdn.microsoft.com/en-us/library/ms714401.aspx) interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A class derived from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The user record.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An array containing cached data for updating the rowset.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The storage unit for the **HROW**.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The storage unit for all row handles held by the provider.  
  
## Members  
  
### Interface Methods (Used with IRowsetChange)  
  
|||  
|-|-|  
|[SetData](../vs140/irowsetupdateimpl--setdata.md)|Sets data values in one or more columns.|  
  
### Interface Methods (Used with IRowsetUpdate)  
  
|||  
|-|-|  
|[GetOriginalData](../vs140/irowsetupdateimpl--getoriginaldata.md)|Gets the data most recently transmitted to or obtained from the data source, ignoring pending changes.|  
|[GetPendingRows](../vs140/irowsetupdateimpl--getpendingrows.md)|Returns a list of rows with pending changes.|  
|[GetRowStatus](../vs140/irowsetupdateimpl--getrowstatus.md)|Returns the status of specified rows.|  
|[Undo](../vs140/irowsetupdateimpl--undo.md)|Undoes any changes to the row since the last fetch or update.|  
|[Update](../vs140/irowsetupdateimpl--update.md)|Transmits any changes made to the row since the last fetch or update.|  
  
### Implementation Methods (Callback)  
  
|||  
|-|-|  
|[IsUpdateAllowed](../vs140/irowsetupdateimpl--isupdateallowed.md)|Used to check for security, integrity, and so on before allowing updates.|  
  
### Data Members  
  
|||  
|-|-|  
|[m_mapCachedData](../vs140/irowsetupdateimpl--m_mapcacheddata.md)|Contains the original data for the deferred operation.|  
  
## Remarks  
 You should first read and understand the documentation for [IRowsetChange](https://msdn.microsoft.com/en-us/library/ms715790.aspx), because everything described there also applies here. You should also read chapter 6 of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> on setting data.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> implements the OLE DB <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> interface, which enables consumers to delay the transmission of changes made with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to the data source and undo changes before transmission.  
  
> [!IMPORTANT]
>  It is strongly recommended that you read the following documentation BEFORE attempting to implement your provider:  
  
-   [Creating an Updatable Provider](../vs140/creating-an-updatable-provider.md)  
  
-   Chapter 6 of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
-   Also see how the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class is used in the UpdatePV sample  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)   
 [Creating an Updatable Provider](../vs140/creating-an-updatable-provider.md)