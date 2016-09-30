---
title: "Getting Field Descriptions from the Properties Window"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Properties window, field descriptions"
ms.assetid: 7d92bb6a-b9b9-4cd8-99e9-b5ee129b52a3
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Getting Field Descriptions from the Properties Window
At the bottom of the **Properties** window, a description area displays information related to the selected property field. This feature is turned on by default. If you want to hide the description field, right-click the **Properties** window and click **Description**. Doing so also removes the check mark next to the **Description** title in the menu window. You can display the field again by following the same steps to toggle **Description** back on.  
  
 The information in the description field comes from \<xref:Microsoft.VisualStudio.OLE.Interop.ITypeInfo*>. Each method, interface, coclass, and so on can have an unlocalized <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> attribute in the type library. The **Properties** window retrieves the string from \<xref:Microsoft.VisualStudio.OLE.Interop.ITypeInfo.GetDocumentation*>.  
  
### To specify localized help strings  
  
1.  Add the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attribute to the library statement in the type library (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
    > [!NOTE]
    >  This step is optional if the type library is in an object library (.olb) file.  
  
2.  Specify <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attributes for the strings. You can also specify <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attributes.  
  
     These attributes are distinct from the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> attributes, which are contained in actual .chm file Help topics.  
  
 To retrieve the description information to be displayed for the highlighted property name, the **Properties** window calls \<xref:System.Runtime.InteropServices.ComTypes.ITypeInfo2.GetDocumentation2*> for the property that is selected, specifying the desired <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attribute for the output string. Internally, \<xref:System.Runtime.InteropServices.ComTypes.ITypeInfo2*> finds the .dll file specified in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> attribute and calls <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> on that .dll file with the specified context and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute.  
  
 The signature and implementation of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> are:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function must be an export defined in the .def file for the DLL.  
  
 Internally, an .olb file is created which is actually a DLL. This DLL contains one resource, the type library (.tlb) file, and one exported function, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 In the case of .olb files, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> attribute is optional because it is the same file that contains the .tlb file itself.  
  
 To get strings to show up in the **Descriptions** pane, therefore, the minimum you have to do is specify the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> attribute in the type library. If you want those strings to be localized, you have to specify the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (optional) attribute and the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> (required) attribute and implement <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 There are no additional interfaces that need to be implemented when getting localized information through idl's <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> attribute and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 Another way of obtaining the localized name and description of a property is by implementing \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing.GetLocalizedPropertyInfo*>. For more information relating to the implementation of this method, see [Properties Window Fields and Interfaces](../vs140/properties-window-fields-and-interfaces.md).  
  
## See Also  
 \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing*>   
 [Properties Window Fields and Interfaces](../vs140/properties-window-fields-and-interfaces.md)   
 [Extending Properties](../vs140/extending-properties.md)   
 [helpstringdll](../vs140/helpstringdll.md)   
 [helpstring](../vs140/helpstring.md)   
 [helpstringcontext](../vs140/helpstringcontext.md)   
 [helpcontext](../vs140/helpcontext.md)   
 [helpfile](../vs140/helpfile.md)   
 [lcid](../vs140/lcid.md)