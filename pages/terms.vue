<template>
  <div>
    <NavSection />
    
    <!-- Terms Header -->
    <section class="bg-gray-50 py-16">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <Icon name="heroicons:scale" class="w-16 h-16 text-gray-700 mx-auto mb-6" />
        <h1 class="text-4xl font-bold text-gray-900 mb-4">
          Terms of Service
        </h1>
        <p class="text-xl text-gray-600 max-w-2xl mx-auto">
          Terms and conditions governing your use of True North Federal Solutions services and website.
        </p>
      </div>
    </section>

    <!-- Terms Content -->
    <section class="py-16 bg-white">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="prose prose-lg max-w-none">
          
          <div class="bg-blue-50 border border-blue-200 rounded-lg p-6 mb-8">
            <p class="text-sm text-blue-800 mb-2"><strong>Last Updated:</strong> December 2024</p>
            <p class="text-sm text-blue-700">
              These Terms of Service ("Terms") govern your use of the True North Federal Solutions website and services.
            </p>
          </div>

          <h2 class="text-2xl font-bold text-gray-900 mb-6">Acceptance of Terms</h2>
          <p class="text-gray-600 mb-6">
            By accessing our website or using our services, you agree to be bound by these Terms. If you disagree with any part of these Terms, you may not access our website or use our services.
          </p>

          <h2 class="text-2xl font-bold text-gray-900 mb-6">Description of Services</h2>
          <p class="text-gray-600 mb-4">
            True North Federal Solutions provides federal contracting consulting services, including:
          </p>
          <ul class="list-disc pl-6 text-gray-600 mb-6">
            <li>Federal contract setup and registration assistance</li>
            <li>Proposal development and review services</li>
            <li>FAR compliance consulting</li>
            <li>Bid/no-bid strategy consulting</li>
            <li>Small business certification guidance</li>
            <li>Educational resources and training materials</li>
          </ul>

          <h2 class="text-2xl font-bold text-gray-900 mb-6">User Responsibilities</h2>
          <p class="text-gray-600 mb-4">You agree to:</p>
          <ul class="list-disc pl-6 text-gray-600 mb-6">
            <li>Provide accurate and complete information</li>
            <li>Use our services for lawful purposes only</li>
            <li>Respect intellectual property rights</li>
            <li>Not interfere with website operation</li>
            <li>Maintain confidentiality of sensitive information shared</li>
          </ul>

          <h2 class="text-2xl font-bold text-gray-900 mb-6">Professional Services Agreement</h2>
          <p class="text-gray-600 mb-6">
            Specific consulting services will be governed by separate professional services agreements that detail scope, deliverables, timelines, and compensation. These Terms supplement but do not replace such agreements.
          </p>

          <h2 class="text-2xl font-bold text-gray-900 mb-6">Intellectual Property</h2>
          <p class="text-gray-600 mb-6">
            All content on this website, including text, graphics, logos, and software, is the property of True North Federal Solutions and is protected by copyright and other intellectual property laws.
          </p>

          <h2 class="text-2xl font-bold text-gray-900 mb-6">Disclaimers</h2>
          <p class="text-gray-600 mb-4">
            Our services are provided "as is" without warranties of any kind. We disclaim all warranties, express or implied, including:
          </p>
          <ul class="list-disc pl-6 text-gray-600 mb-6">
            <li>Warranties of merchantability or fitness for a particular purpose</li>
            <li>Guarantees of specific outcomes or contract awards</li>
            <li>Warranties regarding website availability or error-free operation</li>
          </ul>

          <h2 class="text-2xl font-bold text-gray-900 mb-6">Limitation of Liability</h2>
          <p class="text-gray-600 mb-6">
            True North Federal Solutions shall not be liable for any indirect, incidental, special, or consequential damages arising from your use of our services or website, even if we have been advised of the possibility of such damages.
          </p>

          <h2 class="text-2xl font-bold text-gray-900 mb-6">Contact Information</h2>
          <div class="bg-gray-50 rounded-lg p-6">
            <p class="text-gray-600 mb-4">
              Questions about these Terms? Contact us at:
            </p>
            <p class="text-gray-600">
              Email: legal@truenorthfederalsolutions.com
            </p>
          </div>

        </div>
      </div>
    </section>
  </div>
</template>

<script setup>
// Set page meta for SEO
definePageMeta({
  title: 'Terms of Service - True North Federal Solutions',
  description: 'Terms and conditions governing your use of True North Federal Solutions services and website.'
})

// Set head for SEO
useHead({
  title: 'Terms of Service - True North Federal Solutions',
  meta: [
    { 
      name: 'description', 
      content: 'Terms of service for True North Federal Solutions. Legal terms and conditions for using our federal contracting consulting services.' 
    },
    { 
      name: 'robots', 
      content: 'noindex, nofollow' 
    }
  ]
})
</script>