---
title: "IDiaTable"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaTable interface"
ms.assetid: c99a2c44-7b72-4e3c-b963-25fe3df3a555
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaTable
Enumerates a DIA data source table.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaTable::get__NewEnum](../vs140/idiatable--get__newenum.md)|Retrieves the [IEnumVARIANT Interface](assetId:///139e3c93-faef-4003-9079-e0e94494db3e) version of this enumerator.|  
|[IDiaTable::get_name](../vs140/idiatable--get_name.md)|Retrieves the name of the table.|  
|[IDiaTable::get_Count](../vs140/idiatable--get_count.md)|Retrieves the number of items in the table.|  
|[IDiaTable::Item](../vs140/idiatable--item.md)|Retrieves a reference to a particular entry index.|  
  
## Remarks  
 This interface implements the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> enumeration methods in the Microsoft.VisualStudio.OLE.Interop namespace. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> enumeration interface is much more efficient for iterating over the table contents than the [IDiaTable::get_Count](../vs140/idiatable--get_count.md) and [IDiaTable::Item](../vs140/idiatable--item.md) methods.  
  
 The interpretation of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface returned from either the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method or the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method (in the Microsoft.VisualStudio.OLE.Interop namespace) is dependent on the type of table. For example, if the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface represents a list of injected sources, the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> interface should be queried for the [IDiaInjectedSource](../vs140/idiainjectedsource.md) interface.  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaEnumTables::Item](../vs140/idiaenumtables--item.md) or [IDiaEnumTables::Next](../vs140/idiaenumtables--next.md) methods.  
  
 The following interfaces are implemented with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> interface (that is, you can query the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> interface for one of the following interfaces):  
  
-   [IDiaEnumSymbols](../vs140/idiaenumsymbols.md)  
  
-   [IDiaEnumSourceFiles](../vs140/idiaenumsourcefiles.md)  
  
-   [IDiaEnumLineNumbers](../vs140/idiaenumlinenumbers.md)  
  
-   [IDiaEnumSectionContribs](../vs140/idiaenumsectioncontribs.md)  
  
-   [IDiaEnumSegments](../vs140/idiaenumsegments.md)  
  
-   [IDiaEnumInjectedSources](../vs140/idiaenuminjectedsources.md)  
  
-   [IDiaEnumFrameData](../vs140/idiaenumframedata.md)  
  
## Example  
 The first function, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, displays the names of all the tables in the session. The second function, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, searches all of the tables for a table that implements a specified interface. The third function, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, shows how to use the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a class that wraps a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and automatically handles freeing the string when the instantiation goes out of scope.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaEnumTables](../vs140/idiaenumtables.md)   
 [IDiaEnumTables::Item](../vs140/idiaenumtables--item.md)   
 [IDiaEnumTables::Next](../vs140/idiaenumtables--next.md)