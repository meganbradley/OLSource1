---
title: "VSIX Color Compiler"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 99395da7-ec34-491d-9baa-0590d23283ce
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# VSIX Color Compiler
The Visual Studio Extension Color Compiler tool is a console application that takes an .xml file representing colors for existing Visual Studio themes and coverts it to a .pkgdef file so that those colors can be used in Visual Studio. Because it’s easy to compare differences between .xml files, this tool is useful for managing custom colors in source control. It also can be hooked into build environments so that the output of the build is a valid .pkgdef file.  
  
 **Theme XML schema**  
  
 A complete theme .xml file looks like this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Theme**  
  
 The \<Theme> element defines an entire theme. A theme must contain at least one \<Category> element. Theme elements are defined like this:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
|||  
|-|-|  
|**Attribute**|**Definition**|  
|Name|[Required] The name of the theme|  
|GUID|[Required] The theme’s GUID (must match GUID formatting)|  
  
 When creating custom colors for Visual Studio, those colors need to be defined for the following themes. If no colors exist for a particular theme, Visual Studio attempts to load the missing colors from the Light theme.  
  
|||  
|-|-|  
|**Theme name**|**Theme GUID**|  
|Light|{de3dbbcd-f642-433c-8353-8f1df4370aba}|  
|Dark|{1ded0138-47ce-435e-84ef-9ec1f439b749}|  
|Blue|{a4d6a176-b948-4b29-8c66-53c97a1ed7d0}|  
|High Contrast|{a4d6a176-b948-4b29-8c66-53c97a1ed7d0}|  
  
 **Category**  
  
 The \<Category> element defines a collection of colors in a theme. Category names provide logical groupings, and should be defined as narrowly as possible. A category must contain at least one \<Color> element. Category elements are defined like this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
|||  
|-|-|  
|**Attribute**|**Definition**|  
|Name|[Required] The name of the category|  
|GUID|[Required] The category’s GUID (must match GUID formatting)|  
  
 **Color**  
  
 The \<Color> element defines a color for a component or state of UI. The preferred naming scheme for a color is [UI type] [State]. Do not use the word “color,” as it is redundant. A color should clearly indicate the element type and the situations, or “state,” for which the color will be applied. A color must not be empty, and must contain either one or both of a \<Background> and \<Foreground> element. Color elements are defined like this:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
|||  
|-|-|  
|**Attribute**|**Definition**|  
|Name|[Required] The name of the color|  
  
 **Background and/or Foreground**  
  
 The \<Background> and \<Foreground> elements define a color’s value and type for either the background or foreground of a UI element. These elements have no children.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
|||  
|-|-|  
|**Attribute**|**Definition**|  
|Type|[Required] The type of the color. It can be one of the following:\<br />\<br /> *CT_INVALID:* The color is invalid or not set.\<br />\<br /> *CT_RAW:* A raw ARGB value.\<br />\<br /> *CT_COLORINDEX:* DO NOT USE.\<br />\<br /> *CT_SYSCOLOR:* A Windows system color from SysColor.\<br />\<br /> *CT_VSCOLOR:* A Visual Studio color from __VSSYSCOLOREX.\<br />\<br /> *CT_AUTOMATIC:* The automatic color.\<br />\<br /> *CT_TRACK_FOREGROUND:* DO NOT USE.\<br />\<br /> *CT_TRACK_BACKGROUND:* DO NOT USE.|  
|Source|[Required] The value of the color represented in hexadecimal|  
  
 All values supported by the __VSCOLORTYPE enumeration are supported by the schema in the Type attribute. However, we recommend that you use only CT_RAW and CT_SYSCOLOR.  
  
 **All together**  
  
 This is a simple example of a valid theme .xml file:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## How to use the tool  
 **Syntax**  
  
 VsixColorCompiler \<XML file> \<PkgDef file> \<Optional Args>  
  
 **Arguments**  
  
||||  
|-|-|-|  
|**Switch name**|**Notes**|**Required or Optional**|  
|Unnamed (.xml file)|This is the first unnamed parameter and is the path to the XML file to convert.|Required|  
|Unnamed (.pkgdef file)|This is the second unnamed parameter and is the output path for the generated .pkgdef file.\<br />\<br /> Default: \<XML Filename>.pkgdef|Optional|  
|/noLogo|Setting this flag stops product and copyright information from printing.|Optional|  
|/?|Print out Help information.|Optional|  
|/help|Print out Help information.|Optional|  
  
 **Examples**  
  
-   VsixColorCompiler D:\xml\colors.xml D:\pkgdef\colors.pkgdef  
  
-   VsixColorCompiler D:\xml\colors.xml /noLogo  
  
## Notes  
  
-   This tool requires that the latest version of the VC++ runtime be installed.  
  
-   Only single files are supported. Bulk conversion via folder paths is not supported.  
  
## Sample output  
 The .pkgdef file generated by the tool will be similar to the below keys:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>