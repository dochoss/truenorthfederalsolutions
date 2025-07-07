<template>
  <div>
    <Hero 
      title="FAR Compliance Services"
      subtitle="Navigate federal acquisition regulations with confidence and expertise"
      background-class="bg-gradient-to-r from-green-600 to-green-800"
    />
    
    <BaseSection>
      <div class="max-w-4xl mx-auto">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Federal Acquisition Regulation Expertise
          </h2>
          <p class="text-xl text-gray-600">
            Comprehensive FAR compliance services to ensure your proposals meet all federal requirements
          </p>
        </div>

        <div class="grid md:grid-cols-2 gap-8 mb-12">
          <BaseCard>
            <div class="p-6">
              <Icon name="heroicons:shield-check" class="w-12 h-12 text-green-600 mb-4" />
              <h3 class="text-xl font-semibold mb-3">Compliance Analysis</h3>
              <p class="text-gray-600">
                Detailed analysis of FAR requirements and how they apply to your specific proposal and contract type.
              </p>
            </div>
          </BaseCard>

          <BaseCard>
            <div class="p-6">
              <Icon name="heroicons:document-check" class="w-12 h-12 text-green-600 mb-4" />
              <h3 class="text-xl font-semibold mb-3">Documentation Review</h3>
              <p class="text-gray-600">
                Comprehensive review of all proposal documents to ensure FAR compliance and regulatory adherence.
              </p>
            </div>
          </BaseCard>

          <BaseCard>
            <div class="p-6">
              <Icon name="heroicons:academic-cap" class="w-12 h-12 text-green-600 mb-4" />
              <h3 class="text-xl font-semibold mb-3">Training & Education</h3>
              <p class="text-gray-600">
                FAR training sessions for your team to build internal compliance expertise and capabilities.
              </p>
            </div>
          </BaseCard>

          <BaseCard>
            <div class="p-6">
              <Icon name="heroicons:exclamation-triangle" class="w-12 h-12 text-green-600 mb-4" />
              <h3 class="text-xl font-semibold mb-3">Risk Assessment</h3>
              <p class="text-gray-600">
                Identify and mitigate compliance risks before they impact your proposal or contract performance.
              </p>
            </div>
          </BaseCard>
        </div>

        <div class="bg-green-50 rounded-lg p-8 mb-12">
          <h3 class="text-2xl font-bold text-green-900 mb-4">Key Compliance Areas</h3>
          <div class="grid md:grid-cols-2 gap-4">
            <ul class="space-y-2">
              <li class="flex items-center text-green-800">
                <Icon name="heroicons:check-circle" class="w-5 h-5 mr-2" />
                Small Business Requirements
              </li>
              <li class="flex items-center text-green-800">
                <Icon name="heroicons:check-circle" class="w-5 h-5 mr-2" />
                Cost Accounting Standards
              </li>
              <li class="flex items-center text-green-800">
                <Icon name="heroicons:check-circle" class="w-5 h-5 mr-2" />
                Labor Standards
              </li>
            </ul>
            <ul class="space-y-2">
              <li class="flex items-center text-green-800">
                <Icon name="heroicons:check-circle" class="w-5 h-5 mr-2" />
                Security Requirements
              </li>
              <li class="flex items-center text-green-800">
                <Icon name="heroicons:check-circle" class="w-5 h-5 mr-2" />
                Socioeconomic Programs
              </li>
              <li class="flex items-center text-green-800">
                <Icon name="heroicons:check-circle" class="w-5 h-5 mr-2" />
                Environmental Standards
              </li>
            </ul>
          </div>
        </div>

        <div class="text-center">
          <p class="text-lg text-gray-600 mb-8">
            Ensure your proposals are fully FAR compliant
          </p>
          <BaseButton variant="primary" size="lg">
            <NuxtLink to="/contact">Schedule Consultation</NuxtLink>
          </BaseButton>
        </div>
      </div>
    </BaseSection>
  </div>
</template>

<script setup>
definePageMeta({
  title: 'FAR Compliance Services',
  description: 'Expert Federal Acquisition Regulation compliance services for government contractors.'
})
</script>
