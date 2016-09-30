---
title: "VSCT XML Schema Reference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio command table configuration files (VSCT), XML schema"
  - "VSCT XML schema elements"
ms.assetid: 49e7efae-e713-4762-a824-96fdaf92cdc9
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# VSCT XML Schema Reference
Provides a table of Command Table Compiler schema elements, with allowed child elements and attributes for each.  
  
 An XML-based command table configuration (.vsct) file defines the command elements that a VSPackage provides to the integrated development environment (IDE). These elements include menu items, menus, toolbars, and combo boxes.  
  
> [!NOTE]
>  The VSCT compiler can run a preprocessor on the .vsct file. Because this is typically the C++ preprocessor, you can define includes and macros that have the same syntax that is used in C++ files. Examples of this are provided in the .vsct file that the **New Project** wizard creates for a VSPackage project.  
  
## Optional Elements  
 Some VSCT elements are optional. If a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> argument is not specified, Group_Undefined:0 will be implied. If an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> argument is not specified, guidOfficeIcon:msotcidNoIcon will be implied. When a shortcut key is defined, the emulation, which is typically unused, is optional.  
  
 Bitmap items may be embedded at compile time by specifying the location of the bitmap strip in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> argument. The bitmap strip is copied during the merge rather than extracted from the resources of the DLL. When an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> argument is provided, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> argument becomes optional, and all slots in the bitmap strip are considered used.  
  
 All GUID and ID values must be defined by using symbolic names. These names may be defined in header files or in VSCT \<Symbols> sections. The symbolic names must be local, included through \<Include> elements, or referenced by \<Extern> elements. A symbolic name is imported from a header file specified in an \<Extern> element if it follows the simple pattern of #define SYMBOL   VALUE. The value may be another symbol as long as that symbol was previously defined. GUID definitions must follow either the OLE or C++ format. ID values may be either decimal digits or hexadecimal digits that are preceded by 0x, as shown in the following lines:  
  
-   {6D484634-E53D-4a2c-ADCB-55145C9362C8}  
  
-   { 0x6d484634, 0xe53d, 0x4a2c, { 0xad, 0xcb, 0x55, 0x14, 0x5c, 0x93, 0x62, 0xc8 } }  
  
 XML comments may be used, but round-trip graphical user interface (GUI) tools might discard them. The contents of \<Annotation> elements are guaranteed to be maintained regardless of format.  
  
## Schema Hierarchy  
 A .vsct file has the following major elements.  
  
 [CommandTable Element](../vs140/commandtable-element.md)  
  
 [Extern Element](../vs140/extern-element.md)  
  
 [Include Element](../vs140/include-element.md)  
  
 [Define Element](../vs140/define-element.md)  
  
 [Commands Element](../vs140/commands-element.md)  
  
 [CommandPlacements Element](../vs140/commandplacements-element.md)  
  
 [VisibilityConstraints Element](../vs140/visibilityconstraints-element.md)  
  
 [KeyBindings Element](../vs140/keybindings-element.md)  
  
 [UsedCommands Element](../vs140/usedcommands-element.md)  
  
 [Parent Element](../vs140/parent-element.md)  
  
 [Icon Element](../vs140/icon-element.md)  
  
 [Strings Element](../vs140/strings-element.md)  
  
 [Command Flag Element](../vs140/command-flag-element.md)  
  
 [Symbols Element](../vs140/symbols-element.md)  
  
 [Conditional Attributes](../vs140/vsct-xml-schema-conditional-attributes.md)  
  
## See Also  
 [How VSPackages Contribute User Interface Elements](../vs140/how-vspackages-add-user-interface-elements.md)   
 [Command Routing in the Visual Studio SDK](../vs140/command-routing-in-vspackages.md)