# Information Architecture & Site Map
## True North Federal Solutions Digital Platform

---

## Overview

This document defines the comprehensive information architecture and site mapping for the True North Federal Solutions digital platform. The architecture is designed to support the company's mission of guiding small businesses through federal contracting while providing scalable self-service tools and educational resources.

---

## User Personas & Objectives

### Primary Users
1. **Prospective Clients** - Small/mid-size business owners exploring federal contracting
2. **Current Clients** - Businesses actively working with True North Federal Solutions
3. **Self-Service Users** - Businesses seeking tools and resources independently

### User Objectives
- **Discover Services**: Understand how True North can help with federal contracting
- **Assess Readiness**: Determine if they're ready for federal contracting
- **Access Resources**: Find guides, templates, and educational content
- **Book Consultations**: Schedule meetings with founder/consultants
- **Track Progress**: Monitor their federal contracting journey

---

## Site Map & Navigation Hierarchy

### Primary Navigation
```
├── Home
├── About
├── Services
│   ├── Federal Contract Setup
│   ├── Proposal Development
│   ├── FAR Compliance Consulting
│   └── Bid/No-Bid Strategy
├── Resources
│   ├── Blog/Articles
│   ├── Guides & Templates
│   ├── Certification Help
│   │   ├── WOSB (Woman-Owned Small Business)
│   │   ├── VOSB (Veteran-Owned Small Business)
│   │   └── 8(a) Business Development
│   └── Tools (Phase 2)
│       ├── Business Readiness Assessment
│       └── Bid/No-Bid Decision Tool
├── Contact
└── Client Portal (Phase 3)
```

### Secondary Navigation
```
├── Footer Links
│   ├── Privacy Policy
│   ├── Terms of Service
│   ├── Accessibility Statement
│   └── Sitemap
├── Utility Pages
│   ├── Search Results
│   ├── 404 Error
│   └── 500 Error
└── Legal & Compliance
    ├── GDPR Compliance
    └── CCPA Compliance
```

---

## Page Definitions & Content Strategy

### 1. Homepage (`/`)
**Purpose**: Convert visitors into leads through value proposition and service overview
**Priority**: Critical
**Content Blocks**:
- Hero section with value proposition
- Service overview with clear CTAs
- Founder credibility section
- Success stories/testimonials
- Lead magnets (free resources)
- Newsletter signup

**SEO Focus**: "federal contracting consulting", "small business federal contracts"

### 2. About (`/about`)
**Purpose**: Build trust and credibility through founder's background
**Priority**: High
**Content Blocks**:
- Founder's federal service background (15 years, GS-06 to Contracting Officer)
- Company mission and values
- Why federal contracting matters for small businesses
- Professional certifications and credentials
- Company story and founding purpose

**SEO Focus**: "federal contracting expert", "contracting officer consultant"

### 3. Services Overview (`/services`)
**Purpose**: Explain service offerings and guide to specific services
**Priority**: High
**Content Blocks**:
- Service overview matrix
- Process overview (how we work)
- Pricing information (if applicable)
- Consultation booking CTA

#### 3.1 Federal Contract Setup (`/services/contract-setup`)
**Purpose**: Detail contract setup services
**Content**: SAM registration, CAGE codes, certifications, compliance setup

#### 3.2 Proposal Development (`/services/proposal-development`)
**Purpose**: Explain proposal writing and development services
**Content**: Proposal strategy, writing, review, submission support

#### 3.3 FAR Compliance Consulting (`/services/far-compliance`)
**Purpose**: Detail FAR compliance services
**Content**: Compliance audits, training, ongoing support

#### 3.4 Bid/No-Bid Strategy (`/services/bid-no-bid-strategy`)
**Purpose**: Explain strategic decision support
**Content**: Opportunity analysis, win probability, resource assessment

### 4. Resources Hub (`/resources`)
**Purpose**: Provide valuable content to establish thought leadership
**Priority**: High
**Content Organization**:
- Featured content
- Content categories
- Search functionality
- Recent articles
- Popular downloads

#### 4.1 Blog/Articles (`/resources/blog`)
**Content Types**:
- Federal contracting best practices
- Industry news and updates
- Success stories and case studies
- Regulatory changes and implications

#### 4.2 Guides & Templates (`/guides`)
**Content Types**:
- Step-by-step guides
- Checklists and templates
- Compliance guides
- Proposal templates

#### 4.3 Certification Help (`/resources/certifications`)
**Sub-sections**:
- WOSB guidance and requirements
- VOSB application process
- 8(a) program navigation
- General certification strategies

### 5. Contact (`/contact`)
**Purpose**: Convert visitors to consultations
**Priority**: Critical
**Content Blocks**:
- Contact form with qualification questions
- Consultation booking integration
- Office location (if applicable)
- Response time expectations
- Alternative contact methods

### 6. Tools (Phase 2) (`/tools`)
**Purpose**: Provide AI-powered self-service assessments
**Priority**: Medium (Phase 2)
**Content**:
- Business Readiness Assessment
- Bid/No-Bid Decision Tool
- Results tracking and history

### 7. Client Portal (Phase 3) (`/portal`)
**Purpose**: Provide secure client access to projects and resources
**Priority**: Low (Phase 3)
**Content**:
- Project dashboards
- Document sharing
- Communication tools
- Progress tracking

---

## URL Structure & SEO Strategy

### URL Patterns
```
Primary Pages:
/ (homepage)
/about
/services
/resources
/contact

Service Pages:
/services/contract-setup
/services/proposal-development
/services/far-compliance
/services/bid-no-bid-strategy

Resource Pages:
/resources/blog
/resources/blog/[slug]
/guides
/guides/[slug]
/resources/certifications
/resources/certifications/[certification-type]

Tool Pages (Phase 2):
/tools
/tools/business-readiness-assessment
/tools/bid-no-bid-decision

Portal (Phase 3):
/portal (login required)
/portal/dashboard
/portal/projects/[project-id]
```

### SEO-Friendly URLs
- Use descriptive, keyword-rich URLs
- Maintain consistent URL patterns
- Implement proper redirects for any URL changes
- Use hyphens for word separation
- Keep URLs under 60 characters when possible

---

## Content Types & Templates

### Page Templates
1. **Homepage Template** - Hero, services overview, testimonials, CTA sections
2. **Service Page Template** - Service description, process, benefits, CTA
3. **About Template** - Story, credentials, values, team
4. **Resource Hub Template** - Category grid, featured content, search
5. **Blog Post Template** - Article content, author info, related posts
6. **Guide Template** - Step-by-step content, downloadable resources
7. **Contact Template** - Form, contact info, consultation booking

### Content Components
- Hero sections with CTAs
- Service feature blocks
- Testimonial cards
- Resource download blocks
- Contact forms
- Newsletter signup
- Social proof elements
- Navigation breadcrumbs

---

## User Journey Flows

### New Visitor Journey
```
1. Landing (Homepage/SEO) → 
2. Learn (About/Services) → 
3. Engage (Resources/Tools) → 
4. Convert (Contact/Consultation)
```

### Returning Visitor Journey
```
1. Direct Access → 
2. Resource Consumption → 
3. Tool Usage → 
4. Deeper Engagement → 
5. Consultation Booking
```

### Client Journey (Phase 3)
```
1. Portal Login → 
2. Project Dashboard → 
3. Resource Access → 
4. Communication → 
5. Progress Tracking
```

---

## Technical Architecture Notes

### Nuxt 3 Implementation
- File-based routing matches URL structure
- Auto-imported components for reusability
- SEO optimization with `useHead()` and meta tags
- Dynamic content through headless CMS integration

### Performance Considerations
- Lazy loading for resource-heavy pages
- Image optimization with Nuxt Image
- Static generation where possible
- CDN integration for global performance

### Accessibility
- WCAG 2.1 AA compliance
- Semantic HTML structure
- Keyboard navigation support
- Screen reader optimization

---

## Phase Implementation Plan

### Phase 1 (Current)
- [x] Information architecture definition
- [ ] Homepage and core pages
- [ ] Basic navigation structure
- [ ] Content management setup
- [ ] SEO foundation

### Phase 2
- [ ] AI tool integration
- [ ] Assessment tools
- [ ] Advanced resource features
- [ ] Enhanced user tracking

### Phase 3
- [ ] Client portal
- [ ] User authentication
- [ ] Advanced dashboard features
- [ ] Project management tools

---

## Success Metrics

### Engagement Metrics
- Average session duration > 3 minutes
- Pages per session > 2.5
- Bounce rate < 60%
- Resource download rate > 15%

### Conversion Metrics
- Contact form completion rate > 5%
- Consultation booking rate > 2%
- Newsletter signup rate > 10%
- Lead qualification rate > 25%

### Content Performance
- Blog engagement rate > 4 minutes average
- Resource download completion > 80%
- Search functionality usage > 20%
- Popular content identification for optimization

---

*Document Version: 1.0*  
*Last Updated: December 2024*  
*Next Review: After Phase 1 implementation*