﻿const { createProxyMiddleware } = require('http-proxy-middleware');

const context = [
    "/series",
];

module.exports = function (app) {
    const appProxy = createProxyMiddleware(context, {
        target: 'https://localhost:7283',
        secure: false
    });

    app.use(appProxy);
};
