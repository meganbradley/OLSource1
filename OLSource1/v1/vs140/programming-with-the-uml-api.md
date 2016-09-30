---
title: "Programming with the UML API"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "UML model, API"
  - "UML model, extending"
ms.assetid: c5937139-49d0-4439-8a9f-89f5e0474618
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Programming with the UML API
The UML API of Visual Studio lets you write code to create, read, and update UML models and diagrams. To see which versions of Visual Studio support UML models, see [Version support for architecture and modeling tools](../vs140/what-s-new-for-design-in-visual-studio.md#VersionSupport).  
  
 In addition to the API reference pages, the following topics describe the API.  
  
|Topic|Example types and methods described|Features described|  
|-----------|-----------------------------------------|------------------------|  
|[How to Navigate Relationships](../vs140/navigate-relationships-with-the-uml-api.md)|UML elements and their properties and associations. For example, IElement and its descendants, including: IClass, IActivity, IUseCase, IComponent, IInteraction, IModel, IPackage|In Visual Studio, UML models conform to the UML specification version 2.1.2, which can be obtained at the [UML Resource Page](http://go.microsoft.com/fwlink/?LinkId=160796). Each type is an interface that has the same name as the UML type, prefixed with "I".|  
|[How to Create Model Elements](../vs140/create-elements-and-relationships-in-uml-models.md)|IPackage.CreateClass()\<br />\<br /> IClass.CreateOperation()|Each element type has methods for creating its children.|  
|[How to Display Model Elements](../vs140/display-a-uml-model-on-diagrams.md)|IShape, IDiagram\<br />\<br /> IShape.Move()|Each element in a model can be represented as a shape on a diagram. In some cases, you can create new shapes for each object. You can move, resize, color, and collapse or expand these shapes.|  
|[How to Access the Model and Context](../vs140/navigate-the-uml-model.md)|IModelStore\<br />\<br /> IDiagramContext|The Model Store stores the model.\<br />\<br /> The Diagram Context gives you access to the current diagram and store.|  
|[How to Link Changes](../vs140/link-uml-model-updates-by-using-transactions.md)|ILinkedUndoContext|You can link a series of changes into one transaction.|  
|[How to: Add Commands and Gestures to a UML Diagram](../vs140/define-a-menu-command-on-a-modeling-diagram.md)|IMenuCommand\<br />\<br /> IGestureExtension\<br />\<br /> ICommandExtension|You can extend a diagram's functionality by defining commands invoked by double-clicking and by dragging onto the diagram.|  
|[How to Define Validation Constraints on UML Models](../vs140/define-validation-constraints-for-uml-models.md)|ValidationContext|You can define validation rules that help you make sure that a model conforms to specified constraints.|  
|[How to Get UML Model Elements from IDataObject](../vs140/get-uml-model-elements-from-idataobject.md)|IElement, IShape|When an element is dragged from UML Model Explorer or a UML diagram to another diagram or application, it is serialized as an IDataObject.|  
|[How to Edit Interactions using the UML API](../vs140/edit-uml-sequence-diagrams-by-using-the-uml-api.md)|IInteraction, ILifeline, IMessage|Creating and updating an interaction diagram is slightly different from working with the other diagram types.|  
|[Creating Extensions for Layer Diagrams](../vs140/extend-layer-diagrams.md)|ILayer, ILayerDiagram|You can write code to create and edit layer diagrams, and also validate program code against them.|  
  
## About the Implementation  
 The UML modeling tools are built on [!INCLUDE[dsl](../vs140/includes/dsl_md.md)]. Each package and each diagram is represented by a [!INCLUDE[dsl](../vs140/includes/dsl_md.md)] model, and a collection of rules and other methods maintains consistency between them.  
  
 Types from that platform are visible in some of the assemblies that you reference in order to write UML extensions. Although you can make extensions to the UML tools by accessing the [!INCLUDE[dsl](../vs140/includes/dsl_md.md)] API, you should bear the following considerations in mind:  
  
-   You might find that some apparently simple changes introduce inconsistencies and unexpected effects.  
  
-   The implementation may change in the future, so that adaptations you make using the [!INCLUDE[dsl](../vs140/includes/dsl_md.md)] API might no longer work.  
  
## The API assemblies  
 This table summarizes the assemblies that provide extensibility for the UML tools, and the namespaces that you are recommended to use.  
  
|Assembly|Namespaces|Provides access to:|  
|--------------|----------------|-------------------------|  
|Microsoft.VisualStudio.Uml.Interfaces|(All)|The UML types.|  
|Microsoft.VisualStudio.ArchitectureTools.Extensibility|\<xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml*>|[Creation methods](../vs140/create-elements-and-relationships-in-uml-models.md)|  
||\<xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation*>|[Diagrams and Shapes](../vs140/display-a-uml-model-on-diagrams.md)|  
||\<xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility*>|[The modeling project](../vs140/read-a-uml-model-in-program-code.md)|  
|Microsoft.VisualStudio.Modeling.Sdk.[version]|\<xref:Microsoft.VisualStudio.Modeling.ExtensionEnablement*>|[Menu command extension](../vs140/define-a-menu-command-on-a-modeling-diagram.md).\<br />\<br /> [Linked Undo transactions](../vs140/link-uml-model-updates-by-using-transactions.md).|  
||\<xref:Microsoft.VisualStudio.Modeling.Validation*>|[Validation](../vs140/define-validation-constraints-for-uml-models.md)|  
||(other namespaces)|Recommended only for advanced use.|  
|Microsoft.VisualStudio.Modeling.Sdk.Diagrams.[version]|\<xref:Microsoft.VisualStudio.Modeling.Diagrams.ExtensionEnablement*>|[Gesture handlers](../vs140/define-a-gesture-handler-on-a-modeling-diagram.md).|  
||(other namespaces)|Recommended only for advanced use.|  
|Microsoft.VisualStudio.TeamFoundation.WorkItemTracking|\<xref:Microsoft.VisualStudio.TeamFoundation.WorkItemTracking*>|[Links to work items](../vs140/define-a-work-item-link-handler.md).|  
|Microsoft.TeamFoundation.WorkItemTracking.Client|\<xref:Microsoft.TeamFoundation.WorkItemTracking.Client*>|[Work items and their fields](../vs140/define-a-work-item-link-handler.md).|  
|Microsoft.TeamFoundation.Client|\<xref:Microsoft.TeamFoundation.Client*>|[Work items and their fields](../vs140/define-a-work-item-link-handler.md).|  
|System.ComponentModel.Composition|\<xref:System.ComponentModel.Composition*>|[Export and Import for MEF components](../vs140/define-and-install-a-modeling-extension.md)|  
|System.Linq|\<xref:System.Linq*>|[Easy manipulation of collections, especially when dealing with relationships](../vs140/navigate-relationships-with-the-uml-api.md).|  
  
## See Also  
 [Extending UML Models and Diagrams](../vs140/extend-uml-models-and-diagrams.md)   
 [API Reference for Modeling Extensibility](../vs140/api-reference-for-uml-modeling-extensibility.md)