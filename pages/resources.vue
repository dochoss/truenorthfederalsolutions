<template>
  <div>
    <!-- Resources Header -->
    <BaseSection variant="secondary" spacing="lg" centered>
      <template #header>
        <IconWrapper icon="heroicons:book-open" variant="primary" size="xl" class="mx-auto mb-6" />
        <h1 class="text-4xl text-center font-bold text-secondary-900 mb-4">
          Federal Contracting Resources
        </h1>
        <p class="text-xl text-center text-secondary-600 max-w-2xl mx-auto">
          Access comprehensive guides, templates, and educational content to help you navigate the federal contracting
          landscape with confidence.
        </p>
      </template>
    </BaseSection>

    <!-- Resource Categories -->
    <BaseSection spacing="lg">
      <div class="grid grid-cols-1 md:grid-cols-3 gap-8 mb-12">
        <!-- Blog & Articles -->
        <BaseCard variant="elevated" padding="lg" interactive>
          <div class="text-center">
            <IconWrapper icon="heroicons:newspaper" variant="primary" size="lg" class="mx-auto mb-6" />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">Blog & Articles</h3>
            <p class="text-secondary-600 mb-6">
              Stay updated with the latest insights, best practices, and industry news in federal contracting.
            </p>
            <BaseButton variant="primary" full-width icon-right="heroicons:arrow-right">
              <NuxtLink to="/resources/blog">
                Read Articles
              </NuxtLink>
            </BaseButton>
          </div>
        </BaseCard>

        <!-- Guides & Templates -->
        <BaseCard variant="elevated" padding="lg" interactive>
          <div class="text-center">
            <IconWrapper icon="heroicons:document-arrow-down" variant="success" size="lg" class="mx-auto mb-6" />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">Guides & Templates</h3>
            <p class="text-secondary-600 mb-6">
              Download practical guides, checklists, and templates to streamline your federal contracting process.
            </p>
            <BaseButton variant="primary" full-width icon-right="heroicons:arrow-right">
              <NuxtLink to="/resources/guides">
                Browse Guides
              </NuxtLink>
            </BaseButton>
          </div>
        </BaseCard>

        <!-- Certification Help -->
        <BaseCard variant="elevated" padding="lg" interactive>
          <div class="text-center">
            <IconWrapper icon="heroicons:academic-cap" variant="accent" size="lg" class="mx-auto mb-6" />
            <h3 class="text-xl font-bold text-secondary-900 mb-4">Certification Help</h3>
            <p class="text-secondary-600 mb-6">
              Navigate the certification process for WOSB, VOSB, 8(a), and other small business programs.
            </p>
            <BaseButton variant="primary" full-width icon-right="heroicons:arrow-right">
              <NuxtLink to="/resources/certifications">
                Get Certified
              </NuxtLink>
            </BaseButton>
          </div>
        </BaseCard>
      </div>
    </BaseSection>

    <!-- Featured Resources -->
    <BaseSection variant="secondary" title="Featured Resources"
      subtitle="Popular downloads and essential guides for federal contracting success" spacing="lg">
      <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">

        <!-- Featured Article 1 -->
        <BaseCard variant="bordered" padding="md" interactive>
          <IconWrapper icon="heroicons:rocket-launch" variant="primary" size="md" class="mb-4" />
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">
            Getting Started in Federal Contracting
          </h3>
          <p class="text-secondary-600 text-sm mb-4">
            A comprehensive guide to starting your federal contracting journey, from registration to first contract.
          </p>
          <template #footer>
            <div class="flex items-center justify-between">
              <span class="text-xs text-secondary-500">Beginner Guide</span>
              <BaseButton variant="tertiary" size="sm">
                Coming Soon
              </BaseButton>
            </div>
          </template>
        </BaseCard>

        <!-- Featured Article 2 -->
        <BaseCard variant="bordered" padding="md" interactive>
          <IconWrapper icon="heroicons:clipboard-document-check" variant="success" size="md" class="mb-4" />
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">
            SAM.gov Registration Checklist
          </h3>
          <p class="text-secondary-600 text-sm mb-4">
            Step-by-step checklist to ensure your SAM.gov registration is complete and accurate for federal contracting.
          </p>
          <template #footer>
            <div class="flex items-center justify-between">
              <span class="text-xs text-secondary-500">Essential Template</span>
              <BaseButton variant="tertiary" size="sm">
                Coming Soon
              </BaseButton>
            </div>
          </template>
        </BaseCard>

        <!-- Featured Article 3 -->
        <BaseCard variant="bordered" padding="md" interactive>
          <IconWrapper icon="heroicons:shield-check" variant="accent" size="md" class="mb-4" />
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">
            WOSB Certification Guide
          </h3>
          <p class="text-secondary-600 text-sm mb-4">
            Complete guide to Woman-Owned Small Business certification, including requirements and application process.
          </p>
          <template #footer>
            <div class="flex items-center justify-between">
              <span class="text-xs text-secondary-500">Certification Guide</span>
              <BaseButton variant="tertiary" size="sm">
                Coming Soon
              </BaseButton>
            </div>
          </template>
        </BaseCard>

        <!-- Featured Article 4 -->
        <BaseCard variant="bordered" padding="md" interactive>
          <IconWrapper icon="heroicons:chart-bar" variant="warning" size="md" class="mb-4" />
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">
            Proposal Writing Best Practices
          </h3>
          <p class="text-secondary-600 text-sm mb-4">
            Learn the key elements of winning federal proposals from a contracting officer's perspective.
          </p>
          <template #footer>
            <div class="flex items-center justify-between">
              <span class="text-xs text-secondary-500">Advanced Guide</span>
              <BaseButton variant="tertiary" size="sm">
                Coming Soon
              </BaseButton>
            </div>
          </template>
        </BaseCard>

        <!-- Featured Article 5 -->
        <BaseCard variant="bordered" padding="md" interactive>
          <IconWrapper icon="heroicons:exclamation-triangle" variant="danger" size="md" class="mb-4" />
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">
            Common FAR Compliance Mistakes
          </h3>
          <p class="text-secondary-600 text-sm mb-4">
            Avoid costly mistakes by understanding the most common FAR compliance issues and how to prevent them.
          </p>
          <template #footer>
            <div class="flex items-center justify-between">
              <span class="text-xs text-secondary-500">Compliance Guide</span>
              <BaseButton variant="tertiary" size="sm">
                Coming Soon
              </BaseButton>
            </div>
          </template>
        </BaseCard>

        <!-- Featured Article 6 -->
        <BaseCard variant="bordered" padding="md" interactive>
          <IconWrapper icon="heroicons:calculator" variant="secondary" size="md" class="mb-4" />
          <h3 class="text-lg font-semibold text-secondary-900 mb-3">
            Bid/No-Bid Decision Framework
          </h3>
          <p class="text-secondary-600 text-sm mb-4">
            Strategic framework to help you make informed decisions about which opportunities to pursue.
          </p>
          <template #footer>
            <div class="flex items-center justify-between">
              <span class="text-xs text-secondary-500">Strategy Tool</span>
              <BaseButton variant="tertiary" size="sm">
                Coming Soon
              </BaseButton>
            </div>
          </template>
        </BaseCard>
      </div>
    </BaseSection>

    <!-- Newsletter Signup -->
    <BaseSection variant="primary" spacing="lg" centered>
      <template #header>
        <IconWrapper icon="heroicons:envelope" variant="primary" size="lg"
          class="mx-auto mb-6 bg-white bg-opacity-20" />
        <h2 class="text-3xl text-left md:text-center font-bold text-white mb-4">
          Stay Updated with Federal Contracting Insights
        </h2>
        <p class="text-xl text-left md:text-center text-primary-100 mb-8">
          Get the latest guides, templates, and industry updates delivered to your inbox monthly.
        </p>
      </template>

      <div class="max-w-md mx-auto">
        <div class="flex gap-4">
          <FormInput placeholder="Enter your email address" type="email" class="flex-1" />
          <BaseButton variant="secondary" size="md">
            Subscribe
          </BaseButton>
        </div>
        <p class="text-sm text-primary-200 mt-4">
          No spam. Unsubscribe at any time. Your information is secure.
        </p>
      </div>
    </BaseSection>

    <!-- Tools Preview (Phase 2) -->
    <BaseSection spacing="lg" centered>
      <BaseCard variant="elevated" padding="lg">
        <div class="text-center">
          <IconWrapper icon="heroicons:cog-6-tooth" variant="secondary" size="xl" class="mx-auto mb-6" />
          <h2 class="text-2xl font-bold text-secondary-900 mb-4">
            AI-Powered Tools Coming Soon
          </h2>
          <p class="text-lg text-secondary-600 mb-6">
            We're developing intelligent assessment tools to help you make better decisions about federal contracting
            opportunities.
          </p>
          <div class="grid grid-cols-1 md:grid-cols-2 gap-6 text-left mb-8">
            <div class="flex items-start space-x-3">
              <Icon name="heroicons:check-circle" class="w-5 h-5 text-success-600 mt-1" />
              <div>
                <h3 class="font-semibold text-secondary-900">Business Readiness Assessment</h3>
                <p class="text-sm text-secondary-600">Evaluate your readiness for federal contracting</p>
              </div>
            </div>
            <div class="flex items-start space-x-3">
              <Icon name="heroicons:check-circle" class="w-5 h-5 text-success-600 mt-1" />
              <div>
                <h3 class="font-semibold text-secondary-900">Bid/No-Bid Decision Tool</h3>
                <p class="text-sm text-secondary-600">Get recommendations on which opportunities to pursue</p>
              </div>
            </div>
          </div>
          <BaseButton variant="primary" icon-left="heroicons:bell">
            <NuxtLink to="/contact">
              Get Notified When Available
            </NuxtLink>
          </BaseButton>
        </div>
      </BaseCard>
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