---
title: "IDiaPropertyStorage"
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
  - "IDiaPropertyStorage interface"
ms.assetid: d3197a38-5973-4e56-873e-4f1b84c3f674
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaPropertyStorage
Allows you to read the persistent properties of a DIA property set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaPropertyStorage::Enum](../vs140/idiapropertystorage--enum.md)|Gets a pointer to an enumerator for properties within this set.|  
|[IDiaPropertyStorage::ReadBOOL](../vs140/idiapropertystorage--readbool.md)|Reads <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> values in a property set.|  
|[IDiaPropertyStorage::ReadBSTR](../vs140/idiapropertystorage--readbstr.md)|Reads <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> values in a property set.|  
|[IDiaPropertyStorage::ReadDWORD](../vs140/idiapropertystorage--readdword.md)|Reads <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> values in a property set.|  
|[IDiaPropertyStorage::ReadLONG](../vs140/idiapropertystorage--readlong.md)|Reads <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> values in a property set.|  
|[IDiaPropertyStorage::ReadMultiple](../vs140/idiapropertystorage--readmultiple.md)|Reads property values in a property set.|  
|[IDiaPropertyStorage::ReadPropertyNames](../vs140/idiapropertystorage--readpropertynames.md)|Gets corresponding string names for given property identifiers.|  
|[IDiaPropertyStorage::ReadULONGLONG](../vs140/idiapropertystorage--readulonglong.md)|Reads <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> values in a property set.|  
  
## Remarks  
 Each property within a property set is identified by a property identifier (ID), a four-byte <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value unique to that set. The properties exposed through the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> interface correspond to the properties available in the parent interface. For example, the properties of the [IDiaSymbol](../vs140/idiasymbol.md) interface can be accessed by name through the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> interface (note, however, that even though the property may be accessible, it does not mean the property is valid for a particular <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object).  
  
## Notes for Callers  
 Obtain this interface by calling the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method on another interface. The following interfaces can be queried for the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> interface:  
  
-   [IDiaSectionContrib](../vs140/idiasectioncontrib.md)  
  
-   [IDiaSegment](../vs140/idiasegment.md)  
  
-   [IDiaInjectedSource](../vs140/idiainjectedsource.md)  
  
-   [IDiaFrameData](../vs140/idiaframedata.md)  
  
-   [IDiaSymbol](../vs140/idiasymbol.md)  
  
-   [IDiaSourceFile](../vs140/idiasourcefile.md)  
  
-   [IDiaLineNumber](../vs140/idialinenumber.md)  
  
## Example  
 This example shows a function that displays all properties exposed by the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object. See the [IDiaEnumInjectedSources](../vs140/idiaenuminjectedsources.md) interface for an example of how the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> interface is obtained from the [IDiaInjectedSource](../vs140/idiainjectedsource.md) interface.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaSession::getEnumTables](../vs140/idiasession--getenumtables.md)   
 [IDiaSectionContrib](../vs140/idiasectioncontrib.md)   
 [IDiaSegment](../vs140/idiasegment.md)   
 [IDiaInjectedSource](../vs140/idiainjectedsource.md)   
 [IDiaFrameData](../vs140/idiaframedata.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [IDiaSourceFile](../vs140/idiasourcefile.md)   
 [IDiaLineNumber](../vs140/idialinenumber.md)   
 [IDiaEnumInjectedSources](../vs140/idiaenuminjectedsources.md)