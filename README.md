# Deployment Status
[![Build and deploy Azure Function App](https://github.com/dochoss/truenorthfederalsolutions/actions/workflows/function-production-deploy.yml/badge.svg?branch=main)](https://github.com/dochoss/truenorthfederalsolutions/actions/workflows/function-production-deploy.yml)

[![Deploy Nuxt site to Pages](https://github.com/dochoss/truenorthfederalsolutions/actions/workflows/GithubPages.yml/badge.svg?branch=main)](https://github.com/dochoss/truenorthfederalsolutions/actions/workflows/GithubPages.yml)

# True North Federal Solutions - Digital Platform

A comprehensive digital platform for True North Federal Solutions LLC, a woman- and veteran-owned consulting firm specializing in federal contracting guidance for small and mid-size businesses.

## 🧭 About True North Federal Solutions

**Finding Your True North in Federal Contracting**

True North Federal Solutions guides small businesses through the complex federal contracting landscape with expert consulting in:

- **Federal Contract Setup** - Registration, certifications, and readiness assessment
- **Proposal Development** - Strategic proposal writing and compliance guidance  
- **FAR Compliance** - Federal Acquisition Regulation expertise and ongoing support
- **Bid/No-Bid Strategy** - Strategic decision-making to maximize win rates and ROI

Founded by a former Contracting Officer with 15 years of federal service experience, we provide insider knowledge to help businesses avoid common pitfalls and build foundations for long-term growth in government contracting.

## 🚀 Project Vision

This digital platform combines a professional consulting website with AI-driven self-service tools to:

- **Scale consulting services** through intelligent automation
- **Educate prospects** with comprehensive resource libraries  
- **Generate qualified leads** through valuable tools and content
- **Establish thought leadership** in the federal contracting space
- **Provide ongoing value** to clients through portal access and resources

## 🛠 Technology Stack

Built with modern, scalable technologies optimized for performance and user experience:

- **[Nuxt 4](https://nuxt.com/docs/getting-started/introduction)** - Vue.js framework for SSR and static generation
- **[Nuxt UI v4](https://ui.nuxt.com/)** - Comprehensive UI component library with Tailwind CSS v4 integration
- **[Tailwind CSS v4](https://tailwindcss.com/)** - Utility-first CSS framework with CSS-first configuration
- **[Nuxt Icon](https://nuxt.com/modules/icon)** - Icon library with Heroicons and Simple Icons
- **[Nuxt Image](https://nuxt.com/modules/image)** - Optimized image handling and performance
- **[Zod](https://zod.dev/)** - TypeScript-first schema validation
- **[Mailchimp](https://mailchimp.com/)** - Newsletter subscription management
- **[GitHub Pages](https://pages.github.com/)** - Static site hosting with CI/CD

## 📚 Downloadable Guides

The platform provides downloadable PDF guides for visitors. The guides system automatically generates an index of available files.

### How It Works

1. **Add PDF files** to the `public/guides/` directory
2. **Run the generator** to create the index:
   ```bash
   npm run generate-guides
   ```
3. The script scans `public/guides/` for PDF files and generates `public/guides/index.json`

### Automatic Generation

The guide index is automatically regenerated during build processes via npm lifecycle hooks:
- `prebuild` - Runs before `npm run build`
- `pregenerate` - Runs before `npm run generate`

### Files

- **[scripts/generate-guides.js](./scripts/generate-guides.js)** - Node.js script that scans for PDFs and generates the index
- **[public/guides/index.json](./public/guides/index.json)** - Generated JSON index consumed by the guides page

## 🎯 Target Audience

### Primary: Small Business Owners (10-100 employees)
- Seeking to enter federal contracting markets
- Need guidance on complex regulations and processes
- Value expert consultation and strategic guidance

### Secondary: Business Development Professionals  
- Responsible for growth at mid-size companies
- Looking to expand into federal markets
- Need efficient tools and data-driven insights

### Tertiary: Existing Federal Contractors
- Want to improve win rates and processes
- Need compliance support and strategic optimization
- Seek competitive advantages and industry insights

---

*Building the future of federal contracting consulting through technology and expertise.*
