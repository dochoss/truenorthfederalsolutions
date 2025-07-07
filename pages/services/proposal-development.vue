<template>
  <div>
    <Hero 
      title="Proposal Development Services"
      subtitle="Expert proposal writing and development to win more federal contracts"
      background-class="bg-gradient-to-r from-blue-600 to-blue-800"
    />
    
    <BaseSection>
      <div class="max-w-4xl mx-auto">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Professional Proposal Development
          </h2>
          <p class="text-xl text-gray-600">
            Comprehensive proposal writing services that help you stand out from the competition
          </p>
        </div>

        <div class="grid md:grid-cols-2 gap-8 mb-12">
          <BaseCard>
            <div class="p-6">
              <Icon name="heroicons:document-text" class="w-12 h-12 text-blue-600 mb-4" />
              <h3 class="text-xl font-semibold mb-3">Technical Writing</h3>
              <p class="text-gray-600">
                Expert technical writing that clearly communicates your capabilities and approach to federal agencies.
              </p>
            </div>
          </BaseCard>

          <BaseCard>
            <div class="p-6">
              <Icon name="heroicons:chart-bar" class="w-12 h-12 text-blue-600 mb-4" />
              <h3 class="text-xl font-semibold mb-3">Compliance Review</h3>
              <p class="text-gray-600">
                Thorough compliance review to ensure your proposal meets all RFP requirements and federal regulations.
              </p>
            </div>
          </BaseCard>

          <BaseCard>
            <div class="p-6">
              <Icon name="heroicons:users" class="w-12 h-12 text-blue-600 mb-4" />
              <h3 class="text-xl font-semibold mb-3">Team Coordination</h3>
              <p class="text-gray-600">
                Coordinate proposal teams and manage timelines to deliver winning proposals on schedule.
              </p>
            </div>
          </BaseCard>

          <BaseCard>
            <div class="p-6">
              <Icon name="heroicons:star" class="w-12 h-12 text-blue-600 mb-4" />
              <h3 class="text-xl font-semibold mb-3">Quality Assurance</h3>
              <p class="text-gray-600">
                Multi-level quality assurance process to ensure your proposal is error-free and compelling.
              </p>
            </div>
          </BaseCard>
        </div>

        <div class="text-center">
          <p class="text-lg text-gray-600 mb-8">
            Ready to improve your proposal win rate?
          </p>
          <BaseButton variant="primary" size="lg">
            <NuxtLink to="/contact">Get Started Today</NuxtLink>
          </BaseButton>
        </div>
      </div>
    </BaseSection>
  </div>
</template>

<script setup>
definePageMeta({
  title: 'Proposal Development Services',
  description: 'Expert proposal writing and development services to help you win more federal contracts.'
})
</script>
