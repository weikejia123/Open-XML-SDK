package DocumentFormat.OpenXml;

/**
 * Defines PresentationDocumentType - type of PresentationDocument.
 */
public enum PresentationDocumentType {
    /** PowerPoint Presentation (*.pptx). */
    Presentation,

    /** PowerPoint Template (*.potx). */
    Template,

    /** PowerPoint Show (*.ppsx). */
    Slideshow,

    /** PowerPoint Macro-Enabled Presentation (*.pptm). */
    MacroEnabledPresentation,

    /** PowerPoint Macro-Enabled Template (*.potm). */
    MacroEnabledTemplate,

    /** PowerPoint Macro-Enabled Show (*.ppsm). */
    MacroEnabledSlideshow,

    /** PowerPoint Add-In (*.ppam). */
    AddIn
}
