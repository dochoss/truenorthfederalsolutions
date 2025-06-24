<template>
  <div>
    <NavSection />
    
    <!-- Contact Header -->
    <section class="bg-blue-50 py-16">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <Icon name="heroicons:envelope" class="w-16 h-16 text-blue-700 mx-auto mb-6" />
        <h1 class="text-4xl font-bold text-gray-900 mb-4">
          Get Started with Federal Contracting
        </h1>
        <p class="text-xl text-gray-600 max-w-2xl mx-auto">
          Ready to navigate the federal contracting landscape? Schedule a consultation to discuss your business goals and learn how we can help you succeed.
        </p>
      </div>
    </section>

    <!-- Contact Form Section -->
    <section class="py-16 bg-white">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="grid grid-cols-1 lg:grid-cols-2 gap-12">
          <!-- Contact Form -->
          <div>
            <h2 class="text-2xl font-bold text-gray-900 mb-6">
              Schedule Your Consultation
            </h2>
            <form class="space-y-6">
              <div class="grid grid-cols-1 sm:grid-cols-2 gap-4">
                <div>
                  <label for="firstName" class="block text-sm font-medium text-gray-700 mb-2">
                    First Name *
                  </label>
                  <input
                    type="text"
                    id="firstName"
                    name="firstName"
                    required
                    class="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-transparent"
                  />
                </div>
                <div>
                  <label for="lastName" class="block text-sm font-medium text-gray-700 mb-2">
                    Last Name *
                  </label>
                  <input
                    type="text"
                    id="lastName"
                    name="lastName"
                    required
                    class="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-transparent"
                  />
                </div>
              </div>

              <div>
                <label for="email" class="block text-sm font-medium text-gray-700 mb-2">
                  Email Address *
                </label>
                <input
                  type="email"
                  id="email"
                  name="email"
                  required
                  class="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-transparent"
                />
              </div>

              <div>
                <label for="company" class="block text-sm font-medium text-gray-700 mb-2">
                  Company Name *
                </label>
                <input
                  type="text"
                  id="company"
                  name="company"
                  required
                  class="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-transparent"
                />
              </div>

              <div>
                <label for="phone" class="block text-sm font-medium text-gray-700 mb-2">
                  Phone Number
                </label>
                <input
                  type="tel"
                  id="phone"
                  name="phone"
                  class="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-transparent"
                />
              </div>

              <div>
                <label for="interest" class="block text-sm font-medium text-gray-700 mb-2">
                  Primary Interest *
                </label>
                <select
                  id="interest"
                  name="interest"
                  required
                  class="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-transparent"
                >
                  <option value="">Select your primary interest...</option>
                  <option value="contract-setup">Federal Contract Setup</option>
                  <option value="proposal-development">Proposal Development</option>
                  <option value="far-compliance">FAR Compliance</option>
                  <option value="bid-no-bid">Bid/No-Bid Strategy</option>
                  <option value="general-consulting">General Consulting</option>
                  <option value="certification-help">Certification Assistance</option>
                </select>
              </div>

              <div>
                <label for="message" class="block text-sm font-medium text-gray-700 mb-2">
                  Tell us about your goals and challenges
                </label>
                <textarea
                  id="message"
                  name="message"
                  rows="4"
                  class="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-transparent"
                  placeholder="Describe your current situation, goals, and how we can help..."
                ></textarea>
              </div>

              <button
                type="submit"
                class="w-full bg-blue-700 text-white py-3 px-6 rounded-md hover:bg-blue-800 transition-colors font-medium"
              >
                Schedule Consultation
              </button>
            </form>
          </div>

          <!-- Contact Information -->
          <div>
            <h2 class="text-2xl font-bold text-gray-900 mb-6">
              Contact Information
            </h2>
            
            <div class="space-y-6">
              <div class="flex items-start space-x-4">
                <Icon name="heroicons:clock" class="w-6 h-6 text-blue-700 mt-1" />
                <div>
                  <h3 class="font-semibold text-gray-900 mb-2">Response Time</h3>
                  <p class="text-gray-600">
                    We respond to all consultation requests within 24 hours during business days.
                  </p>
                </div>
              </div>

              <div class="flex items-start space-x-4">
                <Icon name="heroicons:chat-bubble-left-right" class="w-6 h-6 text-blue-700 mt-1" />
                <div>
                  <h3 class="font-semibold text-gray-900 mb-2">Consultation Format</h3>
                  <p class="text-gray-600">
                    Initial consultations are conducted via phone or video call and typically last 30-45 minutes.
                  </p>
                </div>
              </div>

              <div class="flex items-start space-x-4">
                <Icon name="heroicons:shield-check" class="w-6 h-6 text-blue-700 mt-1" />
                <div>
                  <h3 class="font-semibold text-gray-900 mb-2">Confidentiality</h3>
                  <p class="text-gray-600">
                    All information shared during consultations is kept strictly confidential.
                  </p>
                </div>
              </div>

              <div class="flex items-start space-x-4">
                <Icon name="heroicons:document-text" class="w-6 h-6 text-blue-700 mt-1" />
                <div>
                  <h3 class="font-semibold text-gray-900 mb-2">Preparation</h3>
                  <p class="text-gray-600">
                    Come prepared with questions about your business goals, current challenges, and federal contracting interests.
                  </p>
                </div>
              </div>
            </div>

            <!-- Newsletter Signup -->
            <div class="mt-12 p-6 bg-blue-50 rounded-lg">
              <h3 class="text-lg font-semibold text-gray-900 mb-3">
                Stay Informed
              </h3>
              <p class="text-gray-600 mb-4">
                Get federal contracting insights, tips, and updates delivered to your inbox.
              </p>
              <form class="flex space-x-2">
                <input
                  type="email"
                  placeholder="Enter your email"
                  class="flex-1 px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-transparent"
                />
                <button
                  type="submit"
                  class="bg-blue-700 text-white px-4 py-2 rounded-md hover:bg-blue-800 transition-colors"
                >
                  Subscribe
                </button>
              </form>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- FAQ Section -->
    <section class="py-16 bg-gray-50">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8">
        <h2 class="text-3xl font-bold text-gray-900 text-center mb-12">
          Frequently Asked Questions
        </h2>
        
        <div class="space-y-6">
          <div class="bg-white rounded-lg p-6 shadow-sm">
            <h3 class="text-lg font-semibold text-gray-900 mb-3">
              What should I expect during the initial consultation?
            </h3>
            <p class="text-gray-600">
              During your initial consultation, we'll assess your business readiness for federal contracting, discuss your goals, and identify the best path forward. We'll also answer your specific questions and provide preliminary guidance.
            </p>
          </div>

          <div class="bg-white rounded-lg p-6 shadow-sm">
            <h3 class="text-lg font-semibold text-gray-900 mb-3">
              Do you work with businesses of all sizes?
            </h3>
            <p class="text-gray-600">
              Yes, we specialize in helping small and mid-size businesses navigate federal contracting. Whether you're just starting or looking to expand your federal presence, we can help.
            </p>
          </div>

          <div class="bg-white rounded-lg p-6 shadow-sm">
            <h3 class="text-lg font-semibold text-gray-900 mb-3">
              What types of certifications do you help with?
            </h3>
            <p class="text-gray-600">
              We assist with various certifications including WOSB (Woman-Owned Small Business), VOSB (Veteran-Owned Small Business), 8(a) Business Development, and other specialized certifications.
            </p>
          </div>

          <div class="bg-white rounded-lg p-6 shadow-sm">
            <h3 class="text-lg font-semibold text-gray-900 mb-3">
              How long does the federal contracting setup process take?
            </h3>
            <p class="text-gray-600">
              The timeline varies depending on your specific needs and the complexity of your business. Basic setup can take 4-8 weeks, while comprehensive preparation including certifications may take 3-6 months.
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
  title: 'Contact - True North Federal Solutions',
  description: 'Schedule a consultation with True North Federal Solutions for expert federal contracting guidance and support.'
})

// Set head for SEO
useHead({
  title: 'Contact Us - True North Federal Solutions',
  meta: [
    { 
      name: 'description', 
      content: 'Ready to start your federal contracting journey? Contact True North Federal Solutions for expert guidance on contract setup, proposal development, and FAR compliance.' 
    },
    { 
      name: 'keywords', 
      content: 'federal contracting consultation, small business consulting, government contracts, proposal development, FAR compliance' 
    }
  ]
})
</script>