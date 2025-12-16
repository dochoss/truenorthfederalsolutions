<template>
  <div>
    <!-- Resources Header -->
    <UPageSection variant="primary" spacing="lg" centered>
      <template #header>
        <UIcon name="i-heroicons-book-open" class="w-16 h-16 text-primary-600 mx-auto mb-6" />
        <h1 class="text-4xl text-center font-bold text-secondary-900 mb-4">
          Federal Contracting Resources
        </h1>
        <p class="text-xl text-center text-secondary-600 max-w-2xl mx-auto">
          Access comprehensive guides, templates, and educational content to help you navigate the federal contracting
          landscape with confidence.
        </p>
      </template>
    </UPageSection>

    <!-- Resource Categories -->
    <BaseSection spacing="lg">
      <div class="grid grid-cols-1 md:grid-cols-3 gap-8 mb-12">
        <!-- Blog & Articles -->
        <UCard variant="elevated" padding="lg" interactive>
          <div class="text-center">
            <UIcon name="i-heroicons-newspaper" class="w-12 h-12 text-primary-600 mx-auto mb-6" />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">Blog & Articles</h3>
            <p class="text-secondary-600 mb-6">
              Stay updated with the latest insights, best practices, and industry news in federal contracting.
            </p>
            <UButton color="primary" block trailing-icon="i-heroicons-arrow-right" to="https://www.linkedin.com/company/true-north-federal-solutions-llc/posts/" target="_blank">
              Read Articles
            </UButton>
          </div>
        </UCard>

        <!-- Guides & Templates -->
        <UCard variant="elevated" padding="lg" interactive>
          <div class="text-center">
            <UIcon name="i-heroicons-document-arrow-down" class="w-12 h-12 text-success-600 mx-auto mb-6" />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">Guides & Templates</h3>
            <p class="text-secondary-600 mb-6">
              Download practical guides, checklists, and templates to streamline your federal contracting process.
            </p>
            <UButton color="primary" block trailing-icon="i-heroicons-arrow-right" to="/guides">
              Browse Guides
            </UButton>
          </div>
        </UCard>

        <!-- Certification Help -->
        <UCard variant="elevated" padding="lg" interactive>
          <div class="text-center">
            <UIcon name="i-heroicons-academic-cap" class="w-12 h-12 text-accent-600 mx-auto mb-6" />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">Certification Help</h3>
            <p class="text-secondary-600 mb-6">
              Navigate the certification process for WOSB, VOSB, 8(a), and other small business programs.
            </p>
            <UButton color="primary" block trailing-icon="i-heroicons-arrow-right" to="/resources/certifications">
              Get Certified
            </UButton>
          </div>
        </UCard>
      </div>
    </BaseSection>

    <!-- Featured Resources -->
    <BaseSection variant="secondary" title="Featured Resources"
      subtitle="Popular downloads and essential guides for federal contracting success" spacing="lg">
      <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">

        <!-- Featured Article 1 -->
        <UCard variant="bordered" padding="md" interactive :full-height="true">
          <UIcon name="i-heroicons-rocket-launch" class="w-8 h-8 text-primary-600 mb-4" />
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">
            Getting Started in Federal Contracting
          </h3>
          <p class="text-secondary-600 text-sm mb-4">
            A comprehensive guide to starting your federal contracting journey, from registration to first contract.
          </p>
          <template #footer>
            <div class="flex items-center justify-between">
              <span class="text-xs text-secondary-500">Beginner Guide</span>
              <UButton variant="ghost" size="sm">
                Coming Soon
              </UButton>
            </div>
          </template>
        </UCard>

        <!-- Featured Article 2 -->
        <UCard variant="bordered" padding="md" interactive :full-height="true">
          <UIcon name="i-heroicons-clipboard-document-check" class="w-8 h-8 text-success-600 mb-4" />
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">
            SAM.gov Registration Checklist
          </h3>
          <p class="text-secondary-600 text-sm mb-4">
            Step-by-step checklist to ensure your SAM.gov registration is complete and accurate for federal contracting.
          </p>
          <template #footer>
            <div class="flex items-center justify-between">
              <span class="text-xs text-secondary-500">Essential Template</span>
              <UButton variant="ghost" size="sm">
                Coming Soon
              </UButton>
            </div>
          </template>
        </UCard>

        <!-- Featured Article 3 -->
        <UCard variant="bordered" padding="md" interactive :full-height="true">
          <UIcon name="i-heroicons-shield-check" class="w-8 h-8 text-accent-600 mb-4" />
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">
            WOSB Certification Guide
          </h3>
          <p class="text-secondary-600 text-sm mb-4">
            Complete guide to Woman-Owned Small Business certification, including requirements and application process.
          </p>
          <template #footer>
            <div class="flex items-center justify-between">
              <span class="text-xs text-secondary-500">Certification Guide</span>
              <UButton variant="ghost" size="sm">
                Coming Soon
              </UButton>
            </div>
          </template>
        </UCard>

        <!-- Featured Article 4 -->
        <UCard variant="bordered" padding="md" interactive :full-height="true">
          <UIcon name="i-heroicons-chart-bar" class="w-8 h-8 text-warning-600 mb-4" />
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">
            Proposal Writing Best Practices
          </h3>
          <p class="text-secondary-600 text-sm mb-4">
            Learn the key elements of winning federal proposals from a contracting officer's perspective.
          </p>
          <template #footer>
            <div class="flex items-center justify-between">
              <span class="text-xs text-secondary-500">Advanced Guide</span>
              <UButton variant="ghost" size="sm">
                Coming Soon
              </UButton>
            </div>
          </template>
        </UCard>

        <!-- Featured Article 5 -->
        <UCard variant="bordered" padding="md" interactive :full-height="true">
          <UIcon name="i-heroicons-exclamation-triangle" class="w-8 h-8 text-error-600 mb-4" />
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">
            Common FAR Compliance Mistakes
          </h3>
          <p class="text-secondary-600 text-sm mb-4">
            Avoid costly mistakes by understanding the most common FAR compliance issues and how to prevent them.
          </p>
          <template #footer>
            <div class="flex items-center justify-between">
              <span class="text-xs text-secondary-500">Compliance Guide</span>
              <UButton variant="ghost" size="sm">
                Coming Soon
              </UButton>
            </div>
          </template>
        </UCard>

        <!-- Featured Article 6 -->
        <UCard variant="bordered" padding="md" interactive :full-height="true">
          <UIcon name="i-heroicons-calculator" class="w-8 h-8 text-secondary-600 mb-4" />
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">
            Bid/No-Bid Decision Framework
          </h3>
          <p class="text-secondary-600 text-sm mb-4">
            Strategic framework to help you make informed decisions about which opportunities to pursue.
          </p>
          <template #footer>
            <div class="flex items-center justify-between">
              <span class="text-xs text-secondary-500">Strategy Tool</span>
              <UButton variant="ghost" size="sm">
                Coming Soon
              </UButton>
            </div>
          </template>
        </UCard>
      </div>
    </BaseSection>

    <!-- Newsletter Signup -->
    <BaseSection variant="primary" spacing="lg" centered>
      <template #header>
        <UIcon name="i-heroicons-envelope" class="w-12 h-12 text-white mx-auto mb-6 bg-white/20 rounded-full p-2" />
        <h2 class="text-3xl text-left md:text-center font-bold text-white mb-4">
          Stay Updated with Federal Contracting Insights
        </h2>
        <p class="text-xl text-left md:text-center text-primary-100 mb-8">
          Get the latest guides, templates, and industry updates delivered to your inbox monthly.
        </p>
      </template>

      <div class="max-w-md mx-auto">
        <div class="flex gap-4">
          <UInput placeholder="Enter your email address" type="email" class="flex-1" />
          <UButton color="primary" variant="outline" size="md">
            Subscribe
          </UButton>
        </div>
        <p class="text-sm text-primary-200 mt-4">
          No spam. Unsubscribe at any time. Your information is secure.
        </p>
      </div>
    </BaseSection>

    <!-- Tools Preview (Phase 2) -->
    <BaseSection spacing="lg" centered>
      <UCard variant="elevated" padding="lg">
        <div class="text-center">
          <UIcon name="i-heroicons-cog-6-tooth" class="w-16 h-16 text-secondary-600 mx-auto mb-6" />
          <h2 class="text-2xl font-bold text-secondary-900 mb-4">
            AI-Powered Tools Coming Soon
          </h2>
          <p class="text-lg text-secondary-600 mb-6">
            We're developing intelligent assessment tools to help you make better decisions about federal contracting
            opportunities.
          </p>
          <div class="grid grid-cols-1 md:grid-cols-2 gap-6 text-left mb-8">
            <div class="flex items-start space-x-3">
              <UIcon name="i-heroicons-check-circle" class="w-5 h-5 text-success-600 mt-1" />
              <div>
                <h3 class="font-semibold text-secondary-900">Business Readiness Assessment</h3>
                <p class="text-sm text-secondary-600">Evaluate your readiness for federal contracting</p>
              </div>
            </div>
            <div class="flex items-start space-x-3">
              <UIcon name="i-heroicons-check-circle" class="w-5 h-5 text-success-600 mt-1" />
              <div>
                <h3 class="font-semibold text-secondary-900">Bid/No-Bid Decision Tool</h3>
                <p class="text-sm text-secondary-600">Get recommendations on which opportunities to pursue</p>
              </div>
            </div>
          </div>
          <UButton color="primary" icon="i-heroicons-bell" to="/contact">
            Get Notified When Available
          </UButton>
        </div>
      </UCard>
    </BaseSection>
  </div>
</template>

<script setup>
// Set page meta for SEO
definePageMeta({
  title: 'Resources - True North Federal Solutions',
  description: 'Federal contracting resources including guides, templates, blog articles, and certification help for small businesses.'
})

// Set head for SEO
useHead({
  title: 'Federal Contracting Resources - True North Federal Solutions',
  meta: [
    {
      name: 'description',
      content: 'Comprehensive federal contracting resources for small businesses. Access guides, templates, articles, and certification help to succeed in government contracting.'
    },
    {
      name: 'keywords',
      content: 'federal contracting resources, government contract guides, SAM.gov registration, WOSB certification, proposal writing, small business'
    }
  ]
})

</script>