<template>
  <div>
    <Hero 
      title="Federal Contracting Guides"
      subtitle="Comprehensive guides and resources to help you succeed in government contracting"
      background-class="bg-gradient-to-r from-emerald-600 to-emerald-800"
    />
    
    <BaseSection>
      <div class="max-w-6xl mx-auto">
        <div class="text-center mb-12">
          <h2 class="text-3xl font-bold text-gray-900 mb-4">
            Expert Guides & Resources
          </h2>
          <p class="text-xl text-gray-600">
            Step-by-step guides to navigate the complex world of federal contracting
          </p>
        </div>

        <!-- Featured Guide -->
        <BaseCard class="mb-12">
          <div class="p-8">
            <div class="flex items-center mb-4">
              <span class="bg-emerald-100 text-emerald-800 text-sm font-medium px-3 py-1 rounded-full">Featured Guide</span>
              <span class="bg-blue-100 text-blue-800 text-sm font-medium px-3 py-1 rounded-full ml-2">Free Download</span>
            </div>
            <h3 class="text-2xl font-bold mb-4">
              The Complete Guide to Federal Proposal Writing
            </h3>
            <p class="text-gray-600 mb-6">
              A comprehensive 50-page guide covering everything from RFP analysis to final submission. Includes templates, checklists, and real-world examples from winning proposals.
            </p>
            <div class="flex flex-wrap gap-4">
              <BaseButton variant="primary">
                Download Free Guide
              </BaseButton>
              <BaseButton variant="outline">
                Preview Contents
              </BaseButton>
            </div>
          </div>
        </BaseCard>

        <!-- Guide Categories -->
        <div class="grid md:grid-cols-2 lg:grid-cols-4 gap-6 mb-12">
          <BaseCard class="text-center p-6 hover:shadow-lg transition-shadow">
            <Icon name="heroicons:rocket-launch" class="w-12 h-12 text-emerald-600 mb-4 mx-auto" />
            <h3 class="font-semibold mb-2">Getting Started</h3>
            <p class="text-sm text-gray-600">New to federal contracting? Start here.</p>
          </BaseCard>

          <BaseCard class="text-center p-6 hover:shadow-lg transition-shadow">
            <Icon name="heroicons:document-text" class="w-12 h-12 text-emerald-600 mb-4 mx-auto" />
            <h3 class="font-semibold mb-2">Proposal Writing</h3>
            <p class="text-sm text-gray-600">Master the art of winning proposals</p>
          </BaseCard>

          <BaseCard class="text-center p-6 hover:shadow-lg transition-shadow">
            <Icon name="heroicons:shield-check" class="w-12 h-12 text-emerald-600 mb-4 mx-auto" />
            <h3 class="font-semibold mb-2">Compliance</h3>
            <p class="text-sm text-gray-600">Navigate regulations and requirements</p>
          </BaseCard>

          <BaseCard class="text-center p-6 hover:shadow-lg transition-shadow">
            <Icon name="heroicons:chart-bar" class="w-12 h-12 text-emerald-600 mb-4 mx-auto" />
            <h3 class="font-semibold mb-2">Growth Strategies</h3>
            <p class="text-sm text-gray-600">Scale your contracting business</p>
          </BaseCard>
        </div>

        <!-- Guides Grid -->
        <div class="space-y-8">
          <!-- Getting Started Guides -->
          <div>
            <h3 class="text-2xl font-bold mb-6 flex items-center">
              <Icon name="heroicons:rocket-launch" class="w-8 h-8 text-emerald-600 mr-3" />
              Getting Started Guides
            </h3>
            <div class="grid md:grid-cols-2 lg:grid-cols-3 gap-6">
              <BaseCard>
                <div class="p-6">
                  <div class="flex items-center mb-3">
                    <span class="bg-green-100 text-green-800 text-xs font-medium px-2 py-1 rounded">Beginner</span>
                  </div>
                  <h4 class="text-lg font-semibold mb-3">Federal Contracting 101</h4>
                  <p class="text-gray-600 mb-4">Learn the basics of government contracting, from registration to your first contract.</p>
                  <BaseButton variant="outline" size="sm">Download Guide</BaseButton>
                </div>
              </BaseCard>

              <BaseCard>
                <div class="p-6">
                  <div class="flex items-center mb-3">
                    <span class="bg-green-100 text-green-800 text-xs font-medium px-2 py-1 rounded">Beginner</span>
                  </div>
                  <h4 class="text-lg font-semibold mb-3">SAM.gov Registration Guide</h4>
                  <p class="text-gray-600 mb-4">Step-by-step instructions for registering your business in SAM.gov successfully.</p>
                  <BaseButton variant="outline" size="sm">Download Guide</BaseButton>
                </div>
              </BaseCard>

              <BaseCard>
                <div class="p-6">
                  <div class="flex items-center mb-3">
                    <span class="bg-yellow-100 text-yellow-800 text-xs font-medium px-2 py-1 rounded">Intermediate</span>
                  </div>
                  <h4 class="text-lg font-semibold mb-3">Understanding Contract Vehicles</h4>
                  <p class="text-gray-600 mb-4">Navigate GSA Schedules, IDIQs, and other federal contract vehicles.</p>
                  <BaseButton variant="outline" size="sm">Download Guide</BaseButton>
                </div>
              </BaseCard>
            </div>
          </div>

          <!-- Proposal Writing Guides -->
          <div>
            <h3 class="text-2xl font-bold mb-6 flex items-center">
              <Icon name="heroicons:document-text" class="w-8 h-8 text-emerald-600 mr-3" />
              Proposal Writing Guides
            </h3>
            <div class="grid md:grid-cols-2 lg:grid-cols-3 gap-6">
              <BaseCard>
                <div class="p-6">
                  <div class="flex items-center mb-3">
                    <span class="bg-yellow-100 text-yellow-800 text-xs font-medium px-2 py-1 rounded">Intermediate</span>
                  </div>
                  <h4 class="text-lg font-semibold mb-3">RFP Analysis Checklist</h4>
                  <p class="text-gray-600 mb-4">Comprehensive checklist to analyze RFPs and identify key requirements.</p>
                  <BaseButton variant="outline" size="sm">Download Guide</BaseButton>
                </div>
              </BaseCard>

              <BaseCard>
                <div class="p-6">
                  <div class="flex items-center mb-3">
                    <span class="bg-red-100 text-red-800 text-xs font-medium px-2 py-1 rounded">Advanced</span>
                  </div>
                  <h4 class="text-lg font-semibold mb-3">Technical Volume Writing</h4>
                  <p class="text-gray-600 mb-4">Master the technical approach section with proven frameworks and examples.</p>
                  <BaseButton variant="outline" size="sm">Download Guide</BaseButton>
                </div>
              </BaseCard>

              <BaseCard>
                <div class="p-6">
                  <div class="flex items-center mb-3">
                    <span class="bg-yellow-100 text-yellow-800 text-xs font-medium px-2 py-1 rounded">Intermediate</span>
                  </div>
                  <h4 class="text-lg font-semibold mb-3">Past Performance Narratives</h4>
                  <p class="text-gray-600 mb-4">Craft compelling past performance examples that win evaluator confidence.</p>
                  <BaseButton variant="outline" size="sm">Download Guide</BaseButton>
                </div>
              </BaseCard>
            </div>
          </div>

          <!-- Compliance Guides -->
          <div>
            <h3 class="text-2xl font-bold mb-6 flex items-center">
              <Icon name="heroicons:shield-check" class="w-8 h-8 text-emerald-600 mr-3" />
              Compliance Guides
            </h3>
            <div class="grid md:grid-cols-2 lg:grid-cols-3 gap-6">
              <BaseCard>
                <div class="p-6">
                  <div class="flex items-center mb-3">
                    <span class="bg-red-100 text-red-800 text-xs font-medium px-2 py-1 rounded">Advanced</span>
                  </div>
                  <h4 class="text-lg font-semibold mb-3">FAR Compliance Handbook</h4>
                  <p class="text-gray-600 mb-4">Navigate Federal Acquisition Regulations with confidence and avoid costly mistakes.</p>
                  <BaseButton variant="outline" size="sm">Download Guide</BaseButton>
                </div>
              </BaseCard>

              <BaseCard>
                <div class="p-6">
                  <div class="flex items-center mb-3">
                    <span class="bg-yellow-100 text-yellow-800 text-xs font-medium px-2 py-1 rounded">Intermediate</span>
                  </div>
                  <h4 class="text-lg font-semibold mb-3">Small Business Certifications</h4>
                  <p class="text-gray-600 mb-4">Guide to obtaining and maintaining small business certifications.</p>
                  <BaseButton variant="outline" size="sm">Download Guide</BaseButton>
                </div>
              </BaseCard>

              <BaseCard>
                <div class="p-6">
                  <div class="flex items-center mb-3">
                    <span class="bg-red-100 text-red-800 text-xs font-medium px-2 py-1 rounded">Advanced</span>
                  </div>
                  <h4 class="text-lg font-semibold mb-3">CMMC 2.0 Readiness</h4>
                  <p class="text-gray-600 mb-4">Prepare for Cybersecurity Maturity Model Certification requirements.</p>
                  <BaseButton variant="outline" size="sm">Download Guide</BaseButton>
                </div>
              </BaseCard>
            </div>
          </div>
        </div>

        <!-- Call to Action -->
        <div class="bg-emerald-50 rounded-lg p-8 mt-12 text-center">
          <h3 class="text-2xl font-bold text-emerald-900 mb-4">
            Need Custom Guidance?
          </h3>
          <p class="text-emerald-700 mb-6">
            Our experts can provide personalized guidance tailored to your specific situation and goals.
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
  title: 'Federal Contracting Guides',
  description: 'Comprehensive guides and resources to help you succeed in government contracting.'
})
</script>
