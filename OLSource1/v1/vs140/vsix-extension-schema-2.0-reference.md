---
title: "VSIX Extension Schema 2.0 Reference"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "vsix"
  - "extension schema"
ms.assetid: 0da81b98-f5e3-40d3-ba9a-94551378d0b4
caps.latest.revision: 29
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# VSIX Extension Schema 2.0 Reference
A VSIX deployment manifest file describes the contents of a VSIX package. The file format is governed by a schema. Version 2.0 of this schema supports the adding of custom types and attributes.  The schema of the manifest is extensible. The manifest loader ignores XML elements and attributes that it doesn’t understand.  
  
> [!IMPORTANT]
>  Visual Studio 2015 can load VSIX files in the Visual Studio 2010, Visual Studio 2012, or Visual Studio 2013 formats.  
  
## Package Manifest Schema  
 The root element of the manifest XML file is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, with a single attribute <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, which is the version of the manifest format. If major changes are made to the format, the version format will be changed. This topic describes manifest format version 2.0, which is specified in the manifest by setting the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attribute to the value Version=”2.0”.  
  
### PackageManifest Element  
 Within the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> root element, you can use the following elements:  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> - Metadata and advertising information about the package itself. Only one <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element is allowed in the manifest.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> - This section defines the way this extension package can be installed, including the application SKUs that it can install into. Only a single <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element is allowed in the manifest. A manifest must have an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element, or this package won't install into any SKU.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> - An optional list of dependencies for this package are defined here.  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> - This section contains all of the assets contained within this package. Without this section, this package won’t surface any content.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> - The manifest schema is flexible enough to allow any other elements. Any child elements not recognized by the manifest loader are exposed in the Extension Manager API as extra XmlElement objects. Using these child elements, VSIX extensions can define additional data in the manifest file that code running in Visual Studio can access at runtime. See \<xref:Microsoft.VisualStudio.ExtensionManager.IExtension.AdditionalElements*> and \<xref:Microsoft.VisualStudio.ExtensionManager.IExtension.LocalizedAdditionalElements*>.  
  
### Metadata Element  
 This section is the metadata about the package, its identity, and advertising information. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> contains the following elements:  
  
-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> - This defines identification information for this package and includes the following attributes:  
  
    -   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> – This attribute must be a unique ID for the package chosen by its author. The name should be qualified the same way CLR types are namespaced: Company.Product.Feature.Name. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> attribute is limited to 100 characters.  
  
    -   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> – This defines the version of this package and its contents. This attribute follows the CLR assembly versioning format: Major.Minor.Build.Revision (1.2.40308.00). A package with a higher version number is considered updates to the package, and can be installed over the existing installed version.  
  
    -   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> – This attribute is the default language for the package and corresponds to the textual data in this manifest. This attribute follows the CLR locale code convention for resource assemblies, for example: en-us, en, fr-fr. You can specify <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to declare a language-neutral extension that will run on any version of Visual Studio. The default value is <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
    -   <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> – This attribute identifies the publisher of this package, either a company or individual name. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> attribute is limited to 100 characters.  
  
-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> - This element specifies the user-friendly package name that is displayed in the Extension Manager UI. The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> content is limited to 100 characters.  
  
-   <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> - This optional element is a short description of the package and its contents that is displayed in Extension Manager UI. The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> content can contain any text that you want, but it's limited to 1000 characters.  
  
-   <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> - This optional element is a URL to a page online that contains a full description of this package. The protocol must be specified as http.  
  
-   <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> - This optional element is a relative path to a license file (.txt, .rtf) contained in the package.  
  
-   <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> - This optional element is either a relative path to a release notes file contained in the package (.txt, .rtf) or else a URL to a website that displays the release notes.  
  
-   <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> - This optional element is a relative path to an image file (png, bmp, jpeg, ico) contained in the package. The icon image should be 32x32 pixels (or will be shrunk to that size) and appears in the listview UI. If no <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> element is specified, the UI uses a default.  
  
-   <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> - This optional element is a relative path to an image file (png, bmp, jpeg) contained in the package. The preview image should be 200x200 pixels, and displayed in the details UI. If no <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> element is specified, the UI uses a default.  
  
-   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> - This optional element lists additional semicolon-delimited text tags that are used for search hints. The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> element is limited to 100 characters.  
  
-   <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> - This optional element is either a relative path to an HTML file or a URL to a website that contains information about how to use the extension or content within this package. This guide is launched as part of an installation.  
  
-   <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> - The manifest schema is flexible enough to allow any other elements. Any child elements that aren't recognized by the manifest loader are exposed as a list of XmlElement objects. Using these child elements, VSIX extensions can define additional data in the manifest file and enumerate them at runtime.  
  
### Installation Element  
 This section defines the way this package can be installed and the application SKUs that it can install into. This section contains the following attributes:  
  
-   <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> – Set this attribute to true if you have an extension that is currently installed for all users, but you are developing an updated version on the same computer. For example, if you have installed MyExtension 1.0 for all users, but you want to debug MyExtension 2.0 on the same computer, set Experimental="true". This attribute is available in Visual Studio 2015 Update 1 and later.  
  
-   <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> – This attribute can take the value “Global” or “ProductExtension”:  
  
    -   “Global” specifies that the installation is not scoped to a specific SKU. For example, this value is used when an Extension SDK is installed.  
  
    -   “ProductExtension” specifies that a traditional VSIX Extension (version 1.0) scoped to individual Visual Studio SKUs is installed. This is the default value.  
  
-   <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> – This optional attribute specifies whether this package will be installed for all users. By default, this attribute is false, which specifies that the package is per user. (When you set this value to true, the installing user must elevate to administrative privilege level to install the resulting VSIX.  
  
-   <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> – This optional attribute specifies whether this package is installed by an MSI. Packages installed by an MSI are installed and managed by MSI (Programs and Features) and not by the Visual Studio Extension Manager.  By default, this attribute is false, which specifies that the package is not installed by an MSI.  
  
-   <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> – This optional attribute specifies whether this package should be considered a system component. System components don't show in the Extension Manager UI and cannot be updated. By default, this attribute is false, which specifies that the package isn't a system component.  
  
-   <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> – The <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> element accepts an open-ended set of attributes that will be exposed at runtime as a name-value pair dictionary.  
  
-   <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> –This element controls the location where the VSIX installer installs the package. If the value of the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> attribute is “ProductExtension” the package must target a SKU which has installed a manifest file as part of its contents to advertise its availability to extensions. The <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> element has the following attributes when the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> attribute has the explicit or default value “ProductExtension”:  
  
    -   <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> – This attribute identifies the package.  The attribute follows the namespace convention: Company.Product.Feature.Name. The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> attribute can contain only alphanumeric characters and is limited to 100 characters. Expected values:  
  
        -   Microsoft.VisualStudio.IntegratedShell  
  
        -   Microsoft.VisualStudio.Pro  
  
        -   Microsoft.VisualStudio.Premium  
  
        -   Microsoft.VisualStudio.Ultimate  
  
        -   Microsoft.VisualStudio.VWDExpress  
  
        -   Microsoft.VisualStudio.VPDExpress  
  
        -   Microsoft.VisualStudio.VSWinExpress  
  
        -   Microsoft.VisualStudio.VSLS  
  
        -   My.Shell.App  
  
    -   <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> – This attribute specifies a version range with the minimum and maximum supported versions of this SKU. A package can detail the versions of the SKUs that it supports. The version range notation is [10.0 – 11.0], where  
  
        -   [ – minimum version inclusive.  
  
        -   ] – maximum version inclusive.  
  
        -   ( - minimum version exclusive.  
  
        -   ) – maximum version exclusive.  
  
        -   Single version # - only the specified version.  
  
        > [!IMPORTANT]
        >  Version 2.0 of the VSIX Schema was introduced in Visual Studio 2012. To use this schema you must have Visual Studio 2012 or later installed on the machine and use the VSIXInstaller.exe that is part of that product. You can target earlier versions of Visual Studio with a Visual Studio 2012 or later VSIXInstaller, but only by using the later versions of the installer.  
  
    -   <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> – The <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> element allows an open-ended set of attributes that'll be exposed at runtime as a name-value pair dictionary.  
  
### Dependencies Element  
 This element contains a list of dependencies that this package declares. If any dependencies are specified, those packages (identified by their <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>) must be have been installed before.  
  
-   <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> element – This child element has the following attributes:  
  
    -   <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> – This attribute must be a unique ID for the dependent package. This identity value must match the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> attribute of a package that this package is dependent on. The <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> attribute follows the namespace convention: Company.Product.Feature.Name. The attribute can contain only alphanumeric characters and is limited to 100 characters.  
  
    -   <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> – This attribute specifies a version range with the minimum and maximum supported versions of this SKU. A package can detail the versions of the SKUs that it supports. The version range notation is [12.0, 13.0], where:  
  
        -   [ – minimum version inclusive.  
  
        -   ] – maximum version inclusive.  
  
        -   ( - minimum version exclusive.  
  
        -   ) – maximum version exclusive.  
  
        -   Single version # - only the specified version.  
  
    -   <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> - This attribute is the display name of the dependent package which is used in UI elements such as dialog boxes and error messages. The attribute is optional unless the dependent package is installed by MSI.  
  
    -   <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> – This optional attribute specifies either the relative path within this VSIX to a nested VSIX package or a URL to the download location for the dependency. This attribute is used to help the user locate the prerequisite package.  
  
    -   <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> – The <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> element accepts an open-ended set of attributes that will be exposed at runtime as a name-value pair dictionary.  
  
### Assets Element  
 This element contains a list of <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> tags for each extension or content element surfaced by this package.  
  
-   <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> -  This element contains the following attributes and elements:  
  
    -   <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> – This is the type of extension or content represented by this element. Each <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> element must have a single <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, but multiple <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> elements may have the same <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>. This attribute should be represented as a fully qualified name, according to namespace conventions. The known types are:  
  
        1.  Microsoft.VisualStudio.VsPackage  
  
        2.  Microsoft.VisualStudio.MefComponent  
  
        3.  Microsoft.VisualStudio.ToolboxControl  
  
        4.  Microsoft.VisualStudio.Samples  
  
        5.  Microsoft.VisualStudio.ProjectTemplate  
  
        6.  Microsoft.VisualStudio.ItemTemplate  
  
        7.  Microsoft.VisualStudio.Assembly  
  
         You can create your own types, and give them unique names. At run time inside Visual Studio, your code can enumerate and access these custom types through the Extension Manager API.  
  
    -   Path – the relative path to the file or folder within the package that contains the asset.  
  
    -   <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> – An open-ended set of attributes that'll be exposed at runtime as a name-value pair dictionary.  
  
         <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> – Any structured content is allowed between an <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> begin and end tag. All elements are exposed as a list of XmlElement objects. VSIX extensions can define structured type-specific metadata in the manifest file and enumerate them at runtime.  
  
### Sample Manifest  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [VSIX Deployment](../vs140/shipping-visual-studio-extensions.md)