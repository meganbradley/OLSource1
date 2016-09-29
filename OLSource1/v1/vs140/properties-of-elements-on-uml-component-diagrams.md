---
title: "Properties of elements on UML component diagrams"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.teamarch.componentdiagram.shapes.properties"
helpviewer_keywords: 
  - "component diagrams, properties"
  - "UML, element properties"
ms.assetid: fa0a9460-6675-4642-aa00-50f8719a892d
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Properties of elements on UML component diagrams
In a UML component diagram, each element on the diagram has properties. To see the properties of an element, right-click the element on the diagram or in **UML Model Explorer** and then click **Properties**. The properties appear in the **Properties** window.  
  
> [!NOTE]
>  This topic is about the properties of elements in UML Component Diagrams. For more information about how to read UML Component Diagrams, see [UML Component Diagrams: Introduction](../vs140/uml-component-diagrams--reference.md). For more information about how to draw UML Component Diagrams, see [UML Component Diagrams: Guidelines](../vs140/uml-component-diagrams--guidelines.md).  
  
## Properties of Elements  
  
|Property|Default|Element|Description|  
|--------------|-------------|-------------|-----------------|  
|**Name**|A default name|All|Identifies the element.|  
|**Qualified Name**|Namespace :: Name|All|Identifies the element uniquely.<br /><br /> A component or type's name is prefixed with the qualified name of the package that contains it.<br /><br /> A part or port's name is prefixed with the qualified name of the component that owns it.|  
|**Work Items**|0 associated|All|The number of work items associated with this element. To associate work items, see [How to: Link Work Items to Model Elements](../vs140/link-model-elements-and-work-items.md).|  
|**Description**|(none)|All|You can make general notes about the element here.|  
|**Color**|(default for the type)|Component, Part, Delegation, Part assembly|The color of the shape. Unlike other properties, this is the color of the shape rather than the model element that the shape displays.|  
|**Is Indirectly Instantiated**|True|Component|The component exists only as a design artifact. At run time, only its parts exist.|  
|**Is Abstract**|False|Component|The component definition can be used only as a generalization from which other components can be specialized.|  
|**Visibility**|Public|Component, Part, Port|**Public** - globally visible.<br /><br /> **Package** - visible within the package.<br /><br /> **Private** - visible within the owning component.<br /><br /> **Protected** - visible to components derived from the owner.|  
|**Type**|Type on creation|Part<br /><br /> Port|The type of a part is a component or class.<br /><br /> The type of a Port is an interface.|  
|**Multiplicity**|1|Part<br /><br /> Port|Indicates how many instances of the specified type form part of the parent component.<br /><br /> `1` - exactly one.<br /><br /> `0..1` - one or none.<br /><br /> `*` - a collection of any number.<br /><br /> `n..m` - a collection of from n to m instances.|  
|**Is Behavior**|False|Port|If true, messages to this port are handled by activities or operations that are described as part of the component, instead of its parts.|  
|**Is Service**|False|Port|If true, this port is part of the published interface of this component.|  
|**LinkedPackage**|Model|Diagram|The default namespace for elements added to this diagram.|  
  
## See Also  
 [UML Component Diagrams: Overview](../vs140/uml-use-case-diagrams--reference.md)   
 [UML Component Diagrams: Guidelines](../vs140/uml-use-case-diagrams--guidelines.md)